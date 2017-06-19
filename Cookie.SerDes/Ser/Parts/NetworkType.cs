using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.Core.Immutables;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Ser.Parts
{
    internal class NetworkType : ISerializerPart
    {
        public bool Predicat(PropertyInfo property) => !PrimitiveTypes.Primitives.Contains(property.PropertyType)
            && property.PropertyType.GetTypeInfo().HasCustomAttribute<NetworkTypeAttribute>();

        public void OnMatch(List<Expression> contentExpressions, PropertyInfo propertyInfo, ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var dlg = typeof(Serializer<>).MakeGenericType(propertyInfo.PropertyType).GetProperty("SerializeAction");

            var paramProp = Expression.Property(paramT, propertyInfo);
            var invokeDlg = Expression.Invoke(Expression.Property(null, dlg), paramProp, paramWriter);

            contentExpressions.Add(invokeDlg);
        }
    }
}
