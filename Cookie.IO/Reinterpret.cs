using System.Runtime.CompilerServices;

namespace Cookie.IO
{
    internal static unsafe class Reinterpret
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FloatAsInt32(float f)
        {
            return *(int*) &f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Int32AsFloat(int i)
        {
            return *(float*) &i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DoubleAsInt64(double d)
        {
            return *(long*) &d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Int64AsDouble(long l)
        {
            return *(double*) &l;
        }
    }
}