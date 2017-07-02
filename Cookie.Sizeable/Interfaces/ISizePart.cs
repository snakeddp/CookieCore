using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.Sizeable.Interfaces
{
    public interface ISizePart
    {
        bool Predicat(PropertyInfo property);

        void OnMatch(List<Expression> expressions, PropertyInfo propertyInfo,
            ParameterExpression paramClass);
    }
}