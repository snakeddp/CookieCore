using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Cookie.Memory.Pooling.Array
{
    public partial class ArrayPool<T>
        where T : struct
    {
        internal class Bucket
        {
            public SemaphoreSlim Semaphore { get; }
            public ConcurrentQueue<ArraySegment<T>> Queue { get; }

            internal Bucket(int size, int numberOfBuckets, T[] buffer, ref int offset)
            {
                Queue = new ConcurrentQueue<ArraySegment<T>>();

                for (var i = 0; i < numberOfBuckets; i++)
                {
                    Queue.Enqueue(new ArraySegment<T>(buffer, offset, size));
                    offset += size;
                }

                Semaphore = new SemaphoreSlim(numberOfBuckets);
            }
        }
    }
}
