using System;
using System.Collections.Immutable;

namespace Cookie.Core.Immutables
{
    public static class PrimitiveTypes
    {
        public static ImmutableList<Type> Primitives = ImmutableList
            .Create(typeof(byte), typeof(sbyte), typeof(short), typeof(ushort),
                typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal));
    }
}