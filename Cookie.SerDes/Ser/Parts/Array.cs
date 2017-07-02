using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Immutables;
using Cookie.Core.Immutables.Helpers.Expressions;
using Cookie.IO.Interfaces;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Ser.Parts
{
    internal class Array : ISerializerPart
    {
        public bool Predicat(PropertyInfo property)
        {
            return property.PropertyType.GetTypeInfo().IsArray;
        }

        public void OnMatch(List<Expression> contentExpressions, PropertyInfo propertyInfo, ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var propType = propertyInfo.PropertyType;
            var elemType = propType.GetElementType();
            var typeLenAttr = propertyInfo.GetCustomAttribute<LengthTypeAttribute>();
            var customVarAttr = propertyInfo.GetCustomAttribute<CustomVarAttribute>();

            var typeLen = typeLenAttr == null ? typeof(short) : typeLenAttr.TypeLen;
            var isTypeLenCustom = typeLenAttr != null && typeLenAttr.IsCustomVar;
            var isContentCustom = customVarAttr != null;
            var isContentPrimitive = PrimitiveTypes.Primitives.Contains(elemType);

            var miLen = isTypeLenCustom
                ? typeof(IWriter).GetMethod("WriteCustom").MakeGenericMethod(typeLen)
                : typeof(IWriter).GetMethod("WriteValue").MakeGenericMethod(typeLen);

            var paramProp = Expression.Property(paramT, propertyInfo);
            var paramLen = ExpressionHelpers.GetLengthProperty(paramT, propertyInfo);
            var i = Expression.Variable(typeof(int), "i");

            var callMiLen = Expression.Call(paramWriter, miLen, Expression.Convert(paramLen, typeLen));

            contentExpressions.Add(callMiLen);

            Expression finalExpression;
            if (!isContentPrimitive)
            {
                var dlg = typeof(Serializer<>).MakeGenericType(elemType).GetProperty("SerializeAction");

                var content = Expression.Invoke(Expression.Property(null, dlg), Expression.ArrayAccess(paramProp, i),
                    paramWriter);

                finalExpression = ExpressionHelpers.For(i,
                    Expression.Constant(0),
                    Expression.LessThan(i, paramLen),
                    Expression.PostIncrementAssign(i),
                    content);
            }
            else
            {
                if (!isContentCustom)
                {
                    if (elemType == typeof(byte) || elemType == typeof(sbyte))
                    {
                        var mi = typeof(IWriter).GetMethod("WriteArray").MakeGenericMethod(elemType);

                        finalExpression = Expression.Call(paramWriter, mi, paramProp, paramLen);
                    }
                    else
                    {
                        var mi = typeof(IWriter).GetMethod("WriteValue").MakeGenericMethod(elemType);

                        var content = Expression.Call(paramWriter, mi,
                            Expression.ArrayAccess(paramProp, i));

                        finalExpression = ExpressionHelpers.For(i,
                            Expression.Constant(0),
                            Expression.LessThan(i, paramLen),
                            Expression.PostIncrementAssign(i),
                            content);
                    }
                }
                else
                {
                    var mi = typeof(IWriter).GetMethod("WriteCustom").MakeGenericMethod(elemType);

                    var content = Expression.Call(paramWriter, mi,
                        Expression.ArrayAccess(paramProp, i));

                    finalExpression = ExpressionHelpers.For(i,
                        Expression.Constant(0),
                        Expression.LessThan(i, paramLen),
                        Expression.PostIncrementAssign(i),
                        content);
                }
            }

            contentExpressions.Add(finalExpression);
        }
    }
}