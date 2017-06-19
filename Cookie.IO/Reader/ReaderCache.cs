using System;
using System.Text;
using Cookie.IO.Enums;
using Cookie.IO.Types;

namespace Cookie.IO.Reader
{
    internal static unsafe class ReaderCache<T>
    {
        public delegate T SingleReadValueDlg(byte* pSrc);
        public static SingleReadValueDlg SingleReadValue { get; internal set; }

        public delegate T SingleReadStringDlg(byte* pSrc, StringType stringType, int n);
        public static SingleReadStringDlg SingleReadString { get; internal set; }

        public delegate T SingleReadCustomDlg(byte* pSrc);
        public static SingleReadCustomDlg SingleReadCustom { get; internal set; }

        public delegate T[] ArrayReadDlg(byte* pSrc, int n);
        public static ArrayReadDlg ArrayRead { get; internal set; }

        public delegate T SingleReadWrappedBoolDlg(byte pSrc, byte offset);
        public static SingleReadWrappedBoolDlg SingleReadWrappedBool { get; internal set; }
    }

    internal static unsafe class ReaderCache
    {
        static ReaderCache()
        {
            ReaderCache<byte>.SingleReadValue = b => *b;
            ReaderCache<sbyte>.SingleReadValue = b => (sbyte)*b;
            ReaderCache<bool>.SingleReadValue = b => *b != 0;
            ReaderCache<short>.SingleReadValue = BigEndian.ReadInt16;
            ReaderCache<ushort>.SingleReadValue = b => (ushort)BigEndian.ReadInt16(b);
            ReaderCache<int>.SingleReadValue = BigEndian.ReadInt32;
            ReaderCache<uint>.SingleReadValue = b => (uint)BigEndian.ReadInt32(b);
            ReaderCache<long>.SingleReadValue = BigEndian.ReadInt64;
            ReaderCache<ulong>.SingleReadValue = b => (ulong)BigEndian.ReadInt64(b);
            ReaderCache<float>.SingleReadValue = b => Reinterpret.Int32AsFloat(ReaderCache<int>.SingleReadValue(b));
            ReaderCache<double>.SingleReadValue = b => Reinterpret.Int64AsDouble(ReaderCache<long>.SingleReadValue(b));

            ReaderCache<decimal>.SingleReadValue = b =>
            {
                decimal result;
                int* d = (int*)&result;

                int lo = ReaderCache<int>.SingleReadValue(b),
                    mid = ReaderCache<int>.SingleReadValue(b + 4),
                    hi = ReaderCache<int>.SingleReadValue(b + 8),
                    flags = ReaderCache<int>.SingleReadValue(b + 12);

                d[0] = flags;
                d[1] = hi;
                d[2] = lo;
                d[3] = mid;

                return result;
            };

            ReaderCache<string>.SingleReadValue =
                b =>
                {
                    var len = ReaderCache<short>.SingleReadValue(b);
                    return Encoding.UTF8.GetString(b + 2, len);
                };

            ReaderCache<string>.SingleReadString =
                (b, t, n) =>
                {
                    if (n != 0)
                        return t == StringType.Ascii ? 
                            Encoding.ASCII.GetString(b, n) : 
                            Encoding.UTF8.GetString(b, n);

                    var len = ReaderCache<short>.SingleReadValue(b);
                    
                    return t == StringType.Ascii ?
                        Encoding.ASCII.GetString(b + 2, len) :
                        Encoding.UTF8.GetString(b + 2, len);
                };

            ReaderCache<bool>.SingleReadWrappedBool = (b, o) => (b & (byte)(1 << o)) != 0;

            ReaderCache<short>.SingleReadCustom = (b) =>
            {
                var result = 0;

                for (var offset = 0; offset < 16; offset += 7, b++)
                {
                    var readByte = ReaderCache<byte>.SingleReadValue(b);
                    var hasNext = (readByte & 128) == 128;

                    if (offset > 0)
                        result += (readByte & sbyte.MaxValue) << offset;
                    else
                        result += readByte & sbyte.MaxValue;

                    if (hasNext) continue;

                    if (result > short.MaxValue)
                        result -= 65536;

                    return (short)result;
                }
                throw new ArgumentOutOfRangeException();
            };

            ReaderCache<int>.SingleReadCustom = (b) =>
            {
                int result = 0;

                for (var offset = 0; offset < 32; offset += 7, b++)
                {
                    var readByte = ReaderCache<byte>.SingleReadValue(b);
                    var hasNext = (readByte & 128) == 128;

                    if (offset > 0)
                        result += (readByte & sbyte.MaxValue) << offset;
                    else
                        result += readByte & sbyte.MaxValue;

                    if (!hasNext)
                        return result;
                }
                throw new ArgumentOutOfRangeException();
            };

            ReaderCache<long>.SingleReadCustom = (b) =>
            {
                var result = new CustomInt64();
                uint readByte = 0;
                int i;

                for (i = 0; i < 28; i += 7, b++)
                {
                    readByte = ReaderCache<byte>.SingleReadValue(b);

                    if (readByte > sbyte.MaxValue)
                    {
                        result.Low = result.Low | (readByte & 127) << i;
                        continue;
                    }

                    result.Low = result.Low | readByte << i;
                    return result.ToNumber();
                }

                if (readByte > sbyte.MaxValue)
                {
                    readByte = readByte & 127;
                    result.Low = result.Low | readByte << i;
                    result.High = readByte >> 4;

                    for (i = 3; i < 32; i += 7, b++)
                    {
                        readByte = ReaderCache<byte>.SingleReadValue(b);

                        if (readByte > sbyte.MaxValue)
                            result.High = result.High | (readByte & 127) << i;
                        else
                        {
                            break;
                        }
                    }
                    result.High = result.High | readByte << i;
                    return result.ToNumber();
                }

                result.Low = result.Low | readByte << i;
                result.High = readByte >> 4;
                return result.ToNumber();
            };

            ReaderCache<ulong>.SingleReadCustom = (b) =>
            {
                var result = new CustomUInt64();
                uint readByte = 0;
                int i;

                for (i = 0; i < 28; i += 7, b++)
                {
                    readByte = ReaderCache<byte>.SingleReadValue(b);

                    if (readByte > sbyte.MaxValue)
                    {
                        result.Low = result.Low | (readByte & 127) << i;
                        continue;
                    }

                    result.Low = result.Low | readByte << i;
                    return result.ToNumber();
                }

                if (readByte > sbyte.MaxValue)
                {
                    readByte = readByte & 127;
                    result.Low = result.Low | readByte << i;
                    result.High = readByte >> 4;

                    for (i = 3; i < 32; i += 7, b++)
                    {
                        readByte = ReaderCache<byte>.SingleReadValue(b);

                        if (readByte > sbyte.MaxValue)
                            result.High = result.High | (readByte & 127) << i;
                        else
                            break;
                    }
                    result.High = result.High | readByte << i;
                    return result.ToNumber();
                }

                result.Low = result.Low | readByte << i;
                result.High = readByte >> 4;
                return result.ToNumber();
            };

            ReaderCache<byte>.ArrayRead = (b, n) =>
            {
                var t = new byte[n];
                fixed (byte* pDst = t)
                {
                    var ps = b;
                    var pd = pDst;

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
                    return t;
                }
            };

            ReaderCache<sbyte>.ArrayRead = (b, n) =>
            {
                var t = new sbyte[n];
                fixed (sbyte* pDst = t)
                {
                    var ps = b;
                    var pd = pDst;

                    for (int i = 0, c = n / 16; i < c; i++)
                    {
                        *(decimal*)pd = *(decimal*)ps;
                        pd += 16;
                        ps += 16;
                    }

                    for (int i = 0, c = n % 16; i < c; i++)
                    {
                        *pd = *(sbyte*)ps;
                        pd++;
                        ps++;
                    }
                    return t;
                }
            };
        }

        internal static void Init()
        { }
    }
}
