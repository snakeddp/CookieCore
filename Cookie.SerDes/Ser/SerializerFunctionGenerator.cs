using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.Core.Helpers;
using Cookie.IO.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.SerDes.Ser
{
    internal class SerializerFunctionGenerator<T>
    {
        private static readonly Type TypeOfT = typeof(T);

        public static Expression<Action<T, IWriter>> MakeMessageSerializerExpression(ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var properties = GetProperties();
            var contentExpressions = new List<Expression>();
            var variablesExpressions = new List<ParameterExpression>();

            var sizeOfTVar = Expression.Variable(typeof(int), "sizeOfT");
            var sizeOfLenVar = Expression.Variable(typeof(int), "sizeOfLen");
            var computedHeader = Expression.Variable(typeof(short), "computed");

            variablesExpressions.Add(sizeOfTVar);
            variablesExpressions.Add(sizeOfLenVar);
            variablesExpressions.Add(computedHeader);

            var sizeOfTMi =
                typeof(SizeMapperManager).GetMethod("SizeOfMessage").MakeGenericMethod(TypeOfT);
            var sizeOfLenMi = typeof(HeaderHelper).GetMethod("SizeOfLength");
            var subComputeMi = typeof(HeaderHelper).GetMethod("SubComputeStaticHeader");

            var callSizeOfT = Expression.Call(sizeOfTMi, paramT, Expression.Constant(false));
            var callSizeOfLen = Expression.Call(sizeOfLenMi, sizeOfTVar);
            var callSub = Expression.Call(subComputeMi,
                Expression.Constant(GetId()),
                sizeOfLenVar);

            contentExpressions.Add(Expression.Assign(sizeOfTVar, callSizeOfT));
            contentExpressions.Add(Expression.Assign(sizeOfLenVar, callSizeOfLen));
            contentExpressions.Add(Expression.Assign(computedHeader, callSub));

            var mi = typeof(IWriter).GetMethod("WriteValue").MakeGenericMethod(subComputeMi.ReturnType);

            var writeHeader = Expression.Call(paramWriter, mi, computedHeader);

            contentExpressions.Add(writeHeader);

            var contentSerExp = new List<Expression>();

            var writeInstanceMi = typeof(Helper).GetMethod("WriteInstanceId");
            var callWriteInstance = Expression.Call(writeInstanceMi, paramWriter);
            contentExpressions.Add(callWriteInstance);

            var writeLenMi = typeof(Helper).GetMethod("WriteLen");
            var callWriteLen = Expression.Call(
                writeLenMi,
                paramWriter,
                sizeOfLenVar,
                sizeOfTVar);
            contentSerExp.Add(callWriteLen);

            foreach (var property in properties)
            foreach (var part in SerializerPartsManager.Parts)
            {
                if (!part.Predicat(property)) continue;
                part.OnMatch(contentSerExp, property, paramT, paramWriter);
                break;
            }

            // null operator to add Expression.Empty() on empty ?
            var blockSer = Expression.Block(contentSerExp);

            var ifExp = Expression.IfThen(
                Expression.GreaterThan(sizeOfLenVar, Expression.Constant(0)),
                blockSer);

            contentExpressions.Add(ifExp);

            var block = Expression.Block(variablesExpressions, contentExpressions);

            var lambda = Expression.Lambda<Action<T, IWriter>>(block, paramT, paramWriter);

            return lambda;
        }

        public static Expression<Action<T, IWriter>> MakeTypeSerializerExpression(ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var properties = GetProperties();

            var contentExpressions = new List<Expression>();
            foreach (var property in properties)
            foreach (var part in SerializerPartsManager.Parts)
            {
                if (!part.Predicat(property)) continue;
                part.OnMatch(contentExpressions, property, paramT, paramWriter);
                break;
            }

            var block = Expression.Block(contentExpressions);

            var lambda = Expression.Lambda<Action<T, IWriter>>(block, paramT, paramWriter);

            return lambda;
        }

        private static short GetId()
        {
            var attr = TypeOfT.GetTypeInfo().HasCustomAttribute<NetworkMessageAttribute>();
            var msgAttr = TypeOfT.GetTypeInfo().GetCustomAttribute<NetworkMessageAttribute>();
            var typeAttr = TypeOfT.GetTypeInfo().GetCustomAttribute<NetworkTypeAttribute>();

            return attr ? msgAttr.Id : typeAttr.Id;
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
                properties.AddRange(
                    type.GetProperties().Where(p => p.CanRead
                                                    && p.CanWrite
                                                    && p.DeclaringType.FullName.Equals(type.FullName)));

            return properties.ToImmutableArray();
        }
    }
}