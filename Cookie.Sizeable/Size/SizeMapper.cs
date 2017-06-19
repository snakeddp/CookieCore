using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using Cookie.Core.Attributes.Class;
using Cookie.Core.Extensions;
using Cookie.Core.Immutables;
using Cookie.Sizeable.Managers;

namespace Cookie.Sizeable.Size
{
    internal static class SizeMapper<T>
    {
        // ReSharper disable once StaticMemberInGenericType
        internal static int Size { get; }
        internal static Func<T, int> ValueSizeFunc { get; }
        internal static Func<T, bool, int> MessageSizeFunc { get; }

        static SizeMapper()
        {
            PartsManager.Init();

            var t = typeof(T);
            var tInfo = t.GetTypeInfo();

            var className = t.Name.ToLower();
            var paramT = Expression.Parameter(typeof(T), className);
            var paramBool = Expression.Parameter(typeof(bool), "includeHeader");

            if (PrimitiveTypes.Primitives.Contains(t))
            {
                Size = Marshal.SizeOf<T>();

                if (CustomTypes.Customs.Contains(t))
                    ValueSizeFunc = ValueSizeFunc = SizeFunctionGenerator<T>.MakeCustomVarSizeExpression(paramT).Compile();
            }
            else if (t == typeof(bool))
                Size = 1;
            else if (t == typeof(string))
                ValueSizeFunc = SizeFunctionGenerator<T>.MakeStringSizeExpression(paramT).Compile();
            else if(tInfo.HasCustomAttribute<NetworkMessageAttribute>())
                MessageSizeFunc = SizeFunctionGenerator<T>.MakeNetworkMessageSizeExpression(paramT, paramBool).Compile();
            else if (tInfo.HasCustomAttribute<NetworkTypeAttribute>())
                ValueSizeFunc = SizeFunctionGenerator<T>.MakeNetworkTypeSizeExpression(paramT).Compile();
            else
                throw new ArgumentException(t.FullName);
        }

        public static void Init()
        { }
    }
}
