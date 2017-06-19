using System.Text;
using Cookie.IO.Types;

namespace Cookie.IO.Writer
{
    internal static unsafe class WriterCache<T>
    {
        public delegate void SingleWriteValueDlg(byte* pDst, T value);
        public static SingleWriteValueDlg SingleWriteValue { get; internal set; }

        public delegate void SingleWriteCustomDlg(byte* pDst, T value);
        public static SingleWriteCustomDlg SingleWriteCustom { get; internal set; }

        public delegate void ArrayWriteDlg(byte* pDst, T[] values, int n);
        public static ArrayWriteDlg ArrayWrite { get; internal set; }

        public delegate byte WrapBoolDlg(T value, byte b, int offset);
        public static WrapBoolDlg SingleWrapBoolean { get; internal set; }
    }

    internal static unsafe class WriterCache
    {
        static WriterCache()
        {
            WriterCache<byte>.SingleWriteValue = (dst, value) => *dst = value;
            WriterCache<sbyte>.SingleWriteValue = (dst, value) => *(sbyte*)dst = value;
            WriterCache<bool>.SingleWriteValue = (dst, value) => WriterCache<byte>.SingleWriteValue(dst, value ? (byte)1 : (byte)0);
            WriterCache<short>.SingleWriteValue = BigEndian.WriteInt16;
            WriterCache<ushort>.SingleWriteValue = (dst, value) => BigEndian.WriteInt16(dst, (short)value);
            WriterCache<int>.SingleWriteValue = BigEndian.WriteInt32;
            WriterCache<uint>.SingleWriteValue = (dst, value) => BigEndian.WriteInt32(dst, (int)value);
            WriterCache<long>.SingleWriteValue = BigEndian.WriteInt64;
            WriterCache<ulong>.SingleWriteValue = (dst, value) => BigEndian.WriteInt64(dst, (long)value);
            WriterCache<float>.SingleWriteValue = (dst, value) => BigEndian.WriteInt32(dst, Reinterpret.FloatAsInt32(value));
            WriterCache<double>.SingleWriteValue = (dst, value) => BigEndian.WriteInt64(dst, Reinterpret.DoubleAsInt64(value));

            WriterCache<decimal>.SingleWriteValue = (dst, value) =>
            {
                var i = (int*)&value;
                int flags = i[0],
                    hi = i[1],
                    lo = i[2],
                    mid = i[3];

                BigEndian.WriteInt32(dst, lo);
                BigEndian.WriteInt32(dst + 4, mid);
                BigEndian.WriteInt32(dst + 8, hi);
                BigEndian.WriteInt32(dst + 12, flags);
            };

            WriterCache<string>.SingleWriteValue = (dst, value) =>
            {
                var b = Encoding.UTF8.GetBytes(value);
                var len = (short)b.Length;

                WriterCache<short>.SingleWriteValue(dst, len);
                WriterCache<byte>.ArrayWrite(dst + 2, b, b.Length);
            };

            WriterCache<bool>.SingleWrapBoolean = (value, b, offset)
                => value ? (byte)(b | (1 << offset)) : (byte)(b & 255 - (1 << offset));

            WriterCache<short>.SingleWriteCustom = (dst, value) =>
            {
                if (value >= 0 && value <= sbyte.MaxValue)
                {
                    WriterCache<byte>.SingleWriteValue(dst, (byte)value);
                    return;
                }

                var c = value & ushort.MaxValue;

                while (c != 0)
                {
                    var b = c & sbyte.MaxValue;
                    c = (int)((uint)c >> 7);

                    if (c > 0)
                        b |= 128;

                    WriterCache<byte>.SingleWriteValue(dst, (byte)b);
                    dst++;
                }
            };

            WriterCache<int>.SingleWriteCustom = (dst, value) =>
            {
                if (value >= 0 && value <= sbyte.MaxValue)
                {
                    WriterCache<byte>.SingleWriteValue(dst, (byte)value);
                    return;
                }

                while (value != 0)
                {
                    var b = value & sbyte.MaxValue;
                    value = (int)((uint)value >> 7);

                    if (value > 0)
                        b |= 128;

                    WriterCache<byte>.SingleWriteValue(dst, (byte)b);
                    dst++;
                }
            };

            WriterCache<long>.SingleWriteCustom = (dst, value) =>
            {
                var val = CustomInt64.FromNumber(value);

                if (val.High == 0)
                {
                    while (val.Low >= 128)
                    {
                        WriterCache<byte>.SingleWriteValue(dst, (byte)(val.Low & 127 | 128));
                        val.Low >>= 7;
                        dst++;
                    }
                    WriterCache<byte>.SingleWriteValue(dst, (byte)val.Low);
                }
                else
                {
                    for (var i = 0; i < 4; i++, dst++)
                    {
                        WriterCache<byte>.SingleWriteValue(dst, (byte)(val.Low & 127 | 128));
                        val.Low = val.Low >> 7;
                    }
                    if ((val.High & 268435455 << 3) == 0)
                    {
                        WriterCache<byte>.SingleWriteValue(dst, (byte)(val.High >> 4 | val.Low));
                    }
                    else
                    {
                        WriterCache<byte>.SingleWriteValue(dst, (byte)((val.High << 4 | val.Low) & 127 | 128));
                        var v = val.High >> 3;
                        while (v >= 128)
                        {
                            WriterCache<byte>.SingleWriteValue(dst, (byte)(v & 127 | 128));
                            v >>= 7;
                            dst++;
                        }
                        WriterCache<byte>.SingleWriteValue(dst, (byte)v);
                    }
                }

            };

            WriterCache<byte>.ArrayWrite = (dst, values, n) => {
                fixed (byte* pSrc = values)
                {
                    var ps = pSrc;
                    var pd = dst;

                    for (int i = 0, c = n / 16; i < c; i++)
                    {
                        *(decimal*)pd = *(decimal*)ps;
                        pd += 16;
                        ps += 16;
                    }

                    for (int i = 0, c = n % 16; i < c; i++)
                    {
                        *pd = *ps;
                        pd++;
                        ps++;
                    }
                }
            };

            WriterCache<sbyte>.ArrayWrite = (dst, values, n) => {
                fixed (sbyte* pSrc = values)
                {
                    var ps = pSrc;
                    var pd = dst;

                    for (int i = 0, c = n / 16; i < c; i++)
                    {
                        *(decimal*)pd = *(decimal*)ps;
                        pd += 16;
                        ps += 16;
                    }

                    for (int i = 0, c = n % 16; i < c; i++)
                    {
                        *(sbyte*)pd = *ps;
                        pd++;
                        ps++;
                    }
                }
            };
        }

        public static void Init()
        { }
    } 
}
