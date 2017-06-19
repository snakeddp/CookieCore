using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Immutables;
using Cookie.IO.Interfaces;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Des.Parts
{
    internal class Primitive : IDeserializerPart
    {
        public bool Predicat(PropertyInfo property) => PrimitiveTypes.Primitives.Contains(property.PropertyType)
                                                       && property.GetCustomAttribute<CustomVarAttribute>() == null;

        public void OnMatch(List<ParameterExpression> variableExpressions, List<Expression> contentExpressions, 
            PropertyInfo propertyInfo, ParameterExpression paramClass, ParameterExpression paramReader)
        {
            var mi = typeof(IReader).GetMethod("ReadValue").MakeGenericMethod(propertyInfo.PropertyType);

            var paramProp = Expression.Property(paramClass, propertyInfo);
            var callReader = Expression.Call(paramReader, mi);

            var assignExp = Expression.Assign(paramProp, callReader);

            contentExpressions.Add(assignExp);
        }
    }
}
