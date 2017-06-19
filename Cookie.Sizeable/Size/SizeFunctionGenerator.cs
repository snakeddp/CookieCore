using Cookie.Core.Attributes.Class;
using Cookie.Core.Helpers;
using Cookie.Sizeable.Managers;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.Sizeable.Size
{
    internal static class SizeFunctionGenerator<T>
    {
        private static readonly Type TypeOfT = typeof(T);

        public static Expression<Func<T, int>> MakeCustomVarSizeExpression(ParameterExpression paramT)
        {
            MethodInfo mi = null;

            if (TypeOfT == typeof(short))
                mi = typeof(CustomVarSize).GetMethod("GetCustomShortSize");
            else if (TypeOfT == typeof(int))
                mi = typeof(CustomVarSize).GetMethod("GetCustomIntSize");
            else if (TypeOfT == typeof(long))
                mi = typeof(CustomVarSize).GetMethod("GetCustomLongSize");

            var result = Expression.Variable(typeof(int), "i");
            var call = Expression.Call(mi, paramT);
            var assign = Expression.Assign(result, call);

            var returnTarget = Expression.Label(typeof(int));
            var returnLabel = Expression.Label(returnTarget, Expression.Constant(0));
            var returnExpression = Expression.Return(returnTarget, result, typeof(int));

            var block = Expression.Block(new[] { result }, assign, returnExpression, returnLabel);
            var lambda = Expression.Lambda<Func<T, int>>(block, paramT);

            return lambda;
        }

        public static Expression<Func<T, int>> MakeStringSizeExpression(ParameterExpression paramT)
        {
            var stringLen = Expression.Property(paramT, "Length");

            var result = Expression.Variable(typeof(int), "i");
            var assign = Expression.Assign(result, Expression.Add(Expression.Constant(2), stringLen));

            var returnTarget = Expression.Label(typeof(int));
            var returnLabel = Expression.Label(returnTarget, Expression.Constant(0));
            var returnExpression = Expression.Return(returnTarget, result, typeof(int));

            var block = Expression.Block(new[] { result }, assign, returnExpression, returnLabel);
            var lambda = Expression.Lambda<Func<T, int>>(block, paramT);

            return lambda;
        }

        public static Expression<Func<T, bool, int>> MakeNetworkMessageSizeExpression(ParameterExpression paramT, ParameterExpression paramBool)
        {
            var result = Expression.Variable(typeof(int), "i");
            var sizeOfLen = typeof(HeaderHelper).GetMethod("SizeOfLength");

            var properties = GetProperties();
            var sizeExpressions = new List<Expression>();

            foreach (var property in properties)
            {
                foreach (var part in PartsManager.Parts)
                {
                    if (!part.Predicat(property)) continue;
                    part.OnMatch(sizeExpressions, property, paramT);
                    break;
                }
            }

            var content = sizeExpressions.Select(e =>
                Expression.AddAssign(result, e))
                .Cast<Expression>()
                .ToList();

            var ifExp = Expression.IfThen(paramBool,
                Expression.AddAssign(result, Expression.Add(Expression.Call(sizeOfLen, result), Expression.Constant(2))));

            content.Add(ifExp);

            var returnTarget = Expression.Label(typeof(int));
            var returnLabel = Expression.Label(returnTarget, Expression.Constant(0));
            var returnExpression = Expression.Return(returnTarget, result, typeof(int));

            content.Add(returnExpression);
            content.Add(returnLabel);


            var block = Expression.Block(new[] { result }, content);

            var lambda = Expression.Lambda<Func<T, bool, int>>(block, paramT, paramBool);

            return lambda;
        }

        public static Expression<Func<T, int>> MakeNetworkTypeSizeExpression(ParameterExpression paramT)
        {
            var properties = GetProperties();
            var sizeExpressions = new List<Expression>();

            foreach (var property in properties)
            {
                foreach (var part in PartsManager.Parts)
                {
                    if (!part.Predicat(property)) continue;
                    part.OnMatch(sizeExpressions, property, paramT);
                    break;
                }
            }

            var result = Expression.Variable(typeof(int), "i");

            var content = sizeExpressions.Select(e =>
                Expression.AddAssign(result, e))
                .Cast<Expression>()
                .ToList();

            if (TypeOfT.GetTypeInfo().GetCustomAttribute<NetworkTypeAttribute>().WriteId)
                content.Add(Expression.AddAssign(result, Expression.Constant(2)));

            var returnTarget = Expression.Label(typeof(int));
            var returnLabel = Expression.Label(returnTarget, Expression.Constant(0));
            var returnExpression = Expression.Return(returnTarget, result, typeof(int));

            content.Add(returnExpression);
            content.Add(returnLabel);

            var block = Expression.Block(new[] { result }, content);

            var lambda = Expression.Lambda<Func<T, int>>(block, paramT);

            return lambda;
        }

        private static ImmutableArray<PropertyInfo> GetProperties()
        {
            var types = new List<TypeInfo>();

            var currentType = TypeOfT.GetTypeInfo();
            do
            {
                types.Add(currentType);
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
