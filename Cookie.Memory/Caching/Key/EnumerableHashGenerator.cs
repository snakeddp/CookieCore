using System.Collections;
using System.Linq;

namespace Cookie.Memory.Caching.Key
{
    public static class EnumerableHashGenerator<T>
        where T : IEnumerable
    {
        public static int GetEnumerableHash(T obj)
        {
            if (ReferenceEquals(null, obj))
                return 0;

            unchecked
            {
                return obj.Cast<object>().Aggregate(17, (current, o) => (current * 486187739) ^ o.GetHashCode());
            }
        }
    }
}
