using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Immutables;
using Cookie.Core.Immutables.Helpers.Expressions;
using Cookie.Sizeable.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.Sizeable.Parts
{
    internal class Array : ISizePart
    {
        public bool Predicat(PropertyInfo property)
        {
            return property.PropertyType.IsArray;
        }

        public void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass)
        {
            var propType = propertyInfo.PropertyType;
            var elemType = propType.GetElementType();
            var typeLenAttr = propertyInfo.GetCustomAttribute<LengthTypeAttribute>();
            var customVarAttr = propertyInfo.GetCustomAttribute<CustomVarAttribute>();

            var isContentCustom = customVarAttr != null;
            var isContentPrimitive = PrimitiveTypes.Primitives.Contains(elemType);

            var paramProp = Expression.Property(paramClass, propertyInfo);
            var paramLen = ExpressionHelpers.GetLengthProperty(paramClass, propertyInfo);

            var sizeOfElemMi = typeof(SizeMapperManager)
                .GetMethods()
                .First(x => !x.GetParameters().Any() && x.Name == "SizeOf").MakeGenericMethod(elemType);

            var sizeOfwithParamMi = typeof(SizeMapperManager)
                .GetMethods()
                .First(x => x.GetParameters().Any()
                            && x.Name == "SizeOf")
                .MakeGenericMethod(elemType);

            var sizeOfAMi = typeof(SizeMapperManager)
                .GetMethods()
                .First(x => x.GetParameters().Any()
                            && x.Name == "SizeOfArray")
                .MakeGenericMethod(elemType);

            var sizeOfPrimitivesMethod = Expression.Call(sizeOfElemMi);
            var sizeOfArrayMethod = Expression.Call(sizeOfAMi, paramProp);

            Expression finalExpression;

            var typeLen = typeLenAttr == null ? typeof(short) : typeLenAttr.TypeLen;
            var isTypeLenCustom = typeLenAttr?.IsCustomVar ?? false;

            var sizeOfPrimitiveTypeLenMi = typeof(SizeMapperManager)
                .GetMethods()
                .First(x => !x.GetParameters().Any() && x.Name == "SizeOf")
                .MakeGenericMethod(typeLen);

            var sizeOfCustomTypeLenMi = typeof(SizeMapperManager)
                .GetMethods()
                .First(x => x.GetParameters().Any()
                            && x.Name == "SizeOf")
                .MakeGenericMethod(typeLen);

            var sizeOfPrimitiveTypeLenMethod = Expression.Call(sizeOfPrimitiveTypeLenMi);
            var sizeOfCustomTypeLen = Expression.Call(sizeOfCustomTypeLenMi, Expression.Convert(paramLen, typeLen));

            if (!isContentPrimitive)
            {
                finalExpression = Expression.Add(sizeOfArrayMethod,
                    isTypeLenCustom ? sizeOfCustomTypeLen : sizeOfPrimitiveTypeLenMethod);
            }
            else
            {
                if (!isContentCustom)
                    finalExpression = Expression.Add(
                        Expression.Multiply(paramLen,
                            sizeOfPrimitivesMethod),
                        isTypeLenCustom ? sizeOfCustomTypeLen : sizeOfPrimitiveTypeLenMethod);
                else
                    finalExpression = Expression.Add(sizeOfArrayMethod,
                        isTypeLenCustom ? sizeOfCustomTypeLen : sizeOfPrimitiveTypeLenMethod);
            }

            expressions.Add(finalExpression);
        }
    }
}