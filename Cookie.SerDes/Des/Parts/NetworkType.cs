using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.Core.Immutables;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Des.Parts
{
    internal class NetworkType : IDeserializerPart
    {
        public bool Predicat(PropertyInfo property) => !PrimitiveTypes.Primitives.Contains(property.PropertyType) 
            && property.PropertyType.GetTypeInfo().HasCustomAttribute<NetworkTypeAttribute>();

        public void OnMatch(List<ParameterExpression> variableExpressions, List<Expression> contentExpressions,
            PropertyInfo propertyInfo, ParameterExpression paramClass, ParameterExpression paramReader)
        {
            var dlg = typeof(Deserializer<>).MakeGenericType(propertyInfo.PropertyType).GetProperty("DeserializeFunc");

            var paramProp = Expression.Property(paramClass, propertyInfo);
            var invokeDlg = Expression.Invoke(Expression.Property(null, dlg), paramReader);

            var assignExp = Expression.Assign(paramProp, invokeDlg);

            contentExpressions.Add(assignExp);
        }
    }
}
