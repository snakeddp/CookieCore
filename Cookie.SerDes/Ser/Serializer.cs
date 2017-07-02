using System;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.IO.Interfaces;

namespace Cookie.SerDes.Ser
{
    internal static class Serializer<T>
    {
        static Serializer()
        {
            SerializerPartsManager.Init();

            var t = typeof(T);
            var tInfo = t.GetTypeInfo();

            var className = t.Name.ToLower();

            if (!tInfo.HasCustomAttribute<NetworkMessageAttribute>()
                && !tInfo.HasCustomAttribute<NetworkTypeAttribute>())
                throw new ArgumentException(nameof(t));

            var paramT = Expression.Parameter(typeof(T), className);
            var paramWriter = Expression.Parameter(typeof(IWriter), "writer");

            SerializeAction = tInfo.HasCustomAttribute<NetworkMessageAttribute>()
                ? SerializerFunctionGenerator<T>.MakeMessageSerializerExpression(paramT, paramWriter).Compile()
                : SerializerFunctionGenerator<T>.MakeTypeSerializerExpression(paramT, paramWriter).Compile();
        }

        public static Action<T, IWriter> SerializeAction { get; }

        internal static void GenerateExpression()
        {
        }
    }
}