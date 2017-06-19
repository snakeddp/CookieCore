using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.IO.Interfaces;

namespace Cookie.SerDes.Des
{
    internal static class DeserializerFunctionGenerator<T>
    {
        private static readonly Type TypeOfT = typeof(T);

        public static Expression<Func<IReader, T>> MakeDeserializerExpression(ParameterExpression paramReader, string className)
        {
            var paramNew = Expression.New(typeof(T).GetConstructor(Type.EmptyTypes));
            var paramT = Expression.Variable(typeof(T), className);
            var assignPacket = Expression.Assign(paramT, paramNew);

            var properties = GetProperties();

            var variableExpressions = new List<ParameterExpression> { paramT };
            var contentExpressions = new List<Expression> { assignPacket };
            foreach (var property in properties)
            {
                foreach (var part in DeserializerPartsManager.Parts)
                {
                    if (!part.Predicat(property)) continue;
                    part.OnMatch(variableExpressions, contentExpressions, property, paramT, paramReader);
                    break;
                }
            }

            var returnTarget = Expression.Label(typeof(T));
            var returnLabel = Expression.Label(returnTarget, paramNew);
            var returnExpression = Expression.Return(returnTarget, paramT, typeof(T));

            contentExpressions.Add(returnExpression);
            contentExpressions.Add(returnLabel);

            var block = Expression.Block(variableExpressions, contentExpressions);

            var lambda = Expression.Lambda<Func<IReader, T>>(block, paramReader);

            return lambda;
        }

        private static ImmutableArray<PropertyInfo> GetProperties()
        {
            var types = new Stack<TypeInfo>();

            var currentType = TypeOfT.GetTypeInfo();
            do
            {
                types.Push(currentType);
                currentType = currentType.BaseType.GetTypeInfo();
            } while (currentType.BaseType != null);

            var properties = new List<PropertyInfo>();

            foreach (var type in types)
            {
                properties.AddRange(
                    type.GetProperties().Where(p => p.CanRead
                                                    && p.CanWrite
                                                    && p.DeclaringType.FullName.Equals(type.FullName)));
            }

            return properties.ToImmutableArray();
        }
    }
}
