using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Sizeable.Interfaces;

namespace Cookie.Sizeable.Parts
{
    internal class Boolean : ISizePart
    {
        public bool Predicat(PropertyInfo property) => property.PropertyType == typeof(bool)
                                               && property.GetCustomAttribute<RegularBoolAttribute>() == null;

        public void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass)
        {
            if(propertyInfo.GetCustomAttribute<ForceNewByteAttribute>() != null)
                expressions.Add(Expression.Constant(1));
        }
    }
}
