using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Cookie.Memory.Caching.Key
{
    public static class HashBuilder
    {
        public static int GenerateHash<T>(T obj)
        {
            return CacheKeyGenerator<T>.HashFunc(obj);
        }

        internal static class CacheKeyGenerator<T>
        {
            internal static readonly Func<T, int> HashFunc;

            static CacheKeyGenerator()
            {
                var paramObj = Expression.Parameter(typeof(T), "obj");

                var properties = typeof(T).GetProperties();

                // compound XOR expression
                var getHashFuncExprs = properties.Select(mi => MakeHashFuncExpression(mi, paramObj));
                var xorChainExpr =
                    getHashFuncExprs.Aggregate((Expression) Expression.Constant(29), LinkHashFuncExpression);

                var lambda = Expression.Lambda<Func<T, int>>(xorChainExpr, paramObj);

                HashFunc = lambda.Compile();
            }

            private static Expression MakeHashFuncExpression(PropertyInfo member, Expression obj)
            {
                var paramProp = Expression.Property(obj, member);
                var memberAccessAsObjExpr = Expression.Convert(paramProp, typeof(object));

                var memberType = paramProp.Type;

                var getHashCodeExpr = IsEnumerableType(memberType)
                    ? MakeCallOnEnumerable(memberType, paramProp)
                    : Expression.Call(memberAccessAsObjExpr, "GetHashCode", Type.EmptyTypes);

                return Expression.Condition(
                    Expression.ReferenceEqual(Expression.Constant(null), memberAccessAsObjExpr), // If member is null
                    Expression.Constant(0), // Return 0
                    getHashCodeExpr); // Return the actual getHashCode call
            }

            private static Expression MakeCallOnEnumerable(Type enumerableType, Expression parameterExpression)
            {
                var comparerMi = typeof(EnumerableHashGenerator<>)
                    .MakeGenericType(enumerableType)
                    .GetMethod("GetEnumerableHashCode");

                return Expression.Call(comparerMi, parameterExpression);
            }

            private static Expression LinkHashFuncExpression(Expression left, Expression right)
            {
                var leftMultiplied = Expression.Multiply(left, Expression.Constant(486187739));
                return Expression.ExclusiveOr(leftMultiplied, right);
            }

            private static bool IsEnumerableType(Type type)
            {
                return typeof(IEnumerable).IsAssignableFrom(type) && type != typeof(string);
            }
        }
    }
}