using System;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.IO.Interfaces;

namespace Cookie.SerDes.Des
{
    internal static class Deserializer<T>
    {
        public static Func<IReader, T> DeserializeFunc { get; }

        static Deserializer()
        {
            DeserializerPartsManager.Init();

            var t = typeof(T);
            var tInfo = t.GetTypeInfo();

            var className = t.Name.ToLower();

            if (!tInfo.HasCustomAttribute<NetworkMessageAttribute>()
                && !tInfo.HasCustomAttribute<NetworkTypeAttribute>())
            {
                throw new ArgumentException(nameof(t));
            }

            var paramReader = Expression.Parameter(typeof(IReader), "reader");

            DeserializeFunc = DeserializerFunctionGenerator<T>.MakeDeserializerExpression(paramReader, className).Compile();
        }

        internal static void GenerateExpression()
        { }
    }
}
