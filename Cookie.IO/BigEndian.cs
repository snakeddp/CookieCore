using System.Runtime.CompilerServices;

namespace Cookie.IO
{
    internal static unsafe class BigEndian
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short ReadInt16(byte* src)
        {
            return (short) ((src[0] << 8) | src[1]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int ReadInt32(byte* src)
        {
            return (src[0] << 24) | (src[1] << 16) | (src[2] << 8) | src[3];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long ReadInt64(byte* src)
        {
            return (uint) ((src[4] << 24) | (src[5] << 16) | (src[6] << 8)) | src[7] |
                   ((long) ((src[0] << 24) | (src[1] << 16) | (src[2] << 8) | src[3]) << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteInt16(byte* dst, short value)
        {
            dst[0] = (byte) (value >> 8);
            dst[1] = (byte) value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteInt32(byte* dst, int value)
        {
            dst[0] = (byte) (value >> 24);
            dst[1] = (byte) (value >> 16);
            dst[2] = (byte) (value >> 8);
            dst[3] = (byte) value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteInt64(byte* dst, long value)
        {
            dst[0] = (byte) (value >> 56);
            dst[1] = (byte) (value >> 48);
            dst[2] = (byte) (value >> 40);
            dst[3] = (byte) (value >> 32);
            dst[4] = (byte) (value >> 24);
            dst[5] = (byte) (value >> 16);
            dst[6] = (byte) (value >> 8);
            dst[7] = (byte) value;
        }
    }
}