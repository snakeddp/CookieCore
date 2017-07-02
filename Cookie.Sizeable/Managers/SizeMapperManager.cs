using System.Linq;
using Cookie.Sizeable.Size;

namespace Cookie.Sizeable.Managers
{
    public static class SizeMapperManager
    {
        public static int SizeOf<T>()
        {
            return SizeMapper<T>.Size;
        }

        public static int SizeOf<T>(T value)
        {
            return SizeMapper<T>.ValueSizeFunc(value);
        }

        public static int SizeOfMessage<T>(T value, bool includeHeader = false)
        {
            return SizeMapper<T>.MessageSizeFunc(value, includeHeader);
        }

        public static int SizeOfArray<T>(T[] value)
        {
            return value.Sum(v => SizeMapper<T>.ValueSizeFunc(v));
        }
    }
}