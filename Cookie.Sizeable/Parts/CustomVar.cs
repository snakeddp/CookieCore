using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Immutables;
using Cookie.Sizeable.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.Sizeable.Parts
{
    internal class CustomVar : ISizePart
    {
        public bool Predicat(PropertyInfo property)
        {
            return CustomTypes.Customs.Contains(property.PropertyType)
                   && property.GetCustomAttribute<CustomVarAttribute>() != null;
        }

        public void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass)
        {
            var paramProp = Expression.Property(paramClass, propertyInfo);

            var mi = typeof(SizeMapperManager).GetMethods().First(x => x.GetParameters().Any() && x.Name == "SizeOf")
                .MakeGenericMethod(propertyInfo.PropertyType);
            var sizeValue = Expression.Call(mi, paramProp);

            expressions.Add(sizeValue);
        }
    }
}