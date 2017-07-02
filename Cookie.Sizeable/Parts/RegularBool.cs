using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Sizeable.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.Sizeable.Parts
{
    internal class RegularBool : ISizePart
    {
        public bool Predicat(PropertyInfo property)
        {
            return property.PropertyType == typeof(bool)
                   && property.GetCustomAttribute<RegularBoolAttribute>() != null;
        }

        public void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass)
        {
            var mi = typeof(SizeMapperManager).GetMethods().First(x => !x.GetParameters().Any() && x.Name == "SizeOf")
                .MakeGenericMethod(propertyInfo.PropertyType);
            var sizeValue = Expression.Call(mi);

            expressions.Add(sizeValue);
        }
    }
}