using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Memory.Caching.Key;
using Cookie.SerDes.Managers;

namespace Cookie.Memory.Caching
{
    public static class CacheManager<T>
        where T : class
    {
        // ReSharper disable once StaticMemberInGenericType
        private static readonly Dictionary<int, byte[]> Cache = new Dictionary<int, byte[]>();
        private static readonly Func<T, byte[]> SerializerFunc;


        static CacheManager()
        {
            var paramT = Expression.Parameter(typeof(T), "paramT");

            SerializerFunc = MakeSerializerFunc(paramT).Compile();
        }

        public static void Init()
        { }

        public static byte[] Serialize(T message)
        {
            var key = HashBuilder.GenerateHash<T>(message);

            if (Cache.TryGetValue(key, out byte[] value))
                return value;

            value = SerializerFunc(message);
            Cache.Add(key, value);

            return value;
        }

        private static Expression<Func<T, byte[]>> MakeSerializerFunc(ParameterExpression paramT)
        {
            var result = Expression.Variable(typeof(byte[]), "result");

            var serMi = typeof(SerDesManager).GetMethods()
                .First(s => s.GetParameters().Length < 2 )
                .MakeGenericMethod(typeof(T));

            var callSer = Expression.Call(serMi, paramT);

            var assignResult = Expression.Assign(result, callSer);

            var returnTarget = Expression.Label(typeof(byte[]));
            var returnLabel = Expression.Label(returnTarget, Expression.Constant(new byte[0]));
            var returnExpression = Expression.Return(returnTarget, result, typeof(byte[]));

            var block = Expression.Block(new [] { result },
                 assignResult, returnExpression, returnLabel);

            var lambda = Expression.Lambda<Func<T, byte[]>>(block, paramT);

            return lambda;
        }
    }
}
