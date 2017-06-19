using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Property;
using Cookie.IO.Interfaces;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Ser.Parts
{
    internal class WrappedBool : ISerializerPart
    {
        public bool Predicat(PropertyInfo property) => property.PropertyType == typeof(bool)
                                               && property.GetCustomAttribute<RegularBoolAttribute>() == null;

        public void OnMatch(List<Expression> contentExpressions, PropertyInfo propertyInfo, ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var paramProp = Expression.Property(paramT, propertyInfo);

            var mi = typeof(IWriter).GetMethod("WriteWrappedBool").MakeGenericMethod(propertyInfo.PropertyType);

            var callWriter = propertyInfo.GetCustomAttribute<ForceNewByteAttribute>() != null
                ? Expression.Call(paramWriter, mi, paramProp, Expression.Constant(0), Expression.Constant(true))
                : Expression.Call(paramWriter, mi, paramProp, Expression.Constant(0), Expression.Constant(false));

            contentExpressions.Add(callWriter);
        }
    }
}
