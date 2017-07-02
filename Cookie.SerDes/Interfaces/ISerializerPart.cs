using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.SerDes.Interfaces
{
    internal interface ISerializerPart
    {
        bool Predicat(PropertyInfo property);

        void OnMatch(List<Expression> contentExpressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass, ParameterExpression paramWriter);
    }
}