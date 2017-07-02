using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.SerDes.Interfaces
{
    internal interface IDeserializerPart
    {
        bool Predicat(PropertyInfo property);

        void OnMatch(List<ParameterExpression> variableExpressions, List<Expression> contentExpressions,
            PropertyInfo propertyInfo, ParameterExpression paramClass, ParameterExpression paramReader);
    }
}