using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.Core.Immutables;
using Cookie.Sizeable.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.Sizeable.Parts
{
    internal class NetworkType : ISizePart
    {
        public bool Predicat(PropertyInfo property)
        {
            return !PrimitiveTypes.Primitives.Contains(property.PropertyType)
                   && property.PropertyType.GetTypeInfo().HasCustomAttribute<NetworkTypeAttribute>();
        }

        public void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass)
        {
            var paramProp = Expression.Property(paramClass, propertyInfo);

            var mi = typeof(SizeMapperManager).GetMethods()
                .First(x => x.GetParameters().Any() && x.Name == "SizeOf")
                .MakeGenericMethod(propertyInfo.PropertyType);

            Expression sizeValue = Expression.Call(mi, paramProp);

            expressions.Add(sizeValue);
        }
    }
}