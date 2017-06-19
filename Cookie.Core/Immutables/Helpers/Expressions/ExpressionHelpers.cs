using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.Core.Immutables.Helpers.Expressions
{
    public static class ExpressionHelpers
    {
        public static Expression For(ParameterExpression loopVar, Expression initValue, Expression condition, Expression increment, Expression loopContent)
        {
            var initAssign = Expression.Assign(loopVar, initValue);
            
            var breakLabel = Expression.Label("LoopBreak");

            var loop = Expression.Block(new[] { loopVar },
                initAssign,
                Expression.Loop(
                    Expression.IfThenElse(
                        condition,
                        Expression.Block(
                            loopContent,
                            increment
                        ),
                        Expression.Break(breakLabel)
                    ),
                breakLabel)
            );

            return loop;
        }

        public static MemberExpression GetLengthProperty(ParameterExpression paramClass, PropertyInfo paramPropInfo)
        {
            var property = Expression.Property(paramClass, paramPropInfo);

            return Expression.Property(property, "Length");
        }
    }
}
