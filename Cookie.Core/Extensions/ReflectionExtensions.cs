using System;
using System.Reflection;

namespace Cookie.Core.Extensions
{
    public static class ReflectionExtensions
    {
        public static bool HasCustomAttribute<T>(this TypeInfo typeInfo)
            where T : Attribute
        {
            return typeInfo.GetCustomAttribute<T>() != null;
        }
    }
}