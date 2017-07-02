using System;
using System.Collections.Generic;
using Cookie.Core.Extensions;

namespace Cookie.Memory.Pooling.Array
{
    public partial class ArrayPool<T> : IArrayPool<T>
    {
        private readonly Dictionary<int, Bucket> _buckets;

        public ArrayPool(int minSize, int maxSize, int buckets)
        {
            if (minSize < 1)
                throw new ArgumentOutOfRangeException(nameof(minSize));
            if (maxSize < 1 || maxSize < minSize)
                throw new ArgumentOutOfRangeException(nameof(maxSize));
            if (buckets < 1)
                throw new ArgumentOutOfRangeException(nameof(buckets));

            MinSize = MathExtensions.NextPowerOf2(minSize);
            MaxSize = MathExtensions.NextPowerOf2(maxSize);

            var currentSize = MinSize;
            var length = 0;
            var count = 0;

            while (currentSize <= MaxSize)
            {
                length += currentSize * buckets;
                currentSize *= 2;
                count++;
            }

            Length = length;
            Array = new T[length];
            _buckets = new Dictionary<int, Bucket>(count);

            currentSize = MinSize;
            var offset = 0;

            while (currentSize <= MaxSize)
            {
                _buckets.Add(currentSize, new Bucket(currentSize, buckets, Array, ref offset));
                currentSize *= 2;
            }
        }

        public int MinSize { get; }
        public int MaxSize { get; }
        public int Length { get; }
        public T[] Array { get; }

        public ArraySegment<T> Take(int minSize)
        {
            if (minSize < 1 || minSize > MaxSize)
                throw new ArgumentOutOfRangeException(nameof(minSize));

            var size = MathExtensions.NextPowerOf2(minSize);
            var bucket = _buckets[size];
            bucket.Semaphore.Wait();
            bucket.Queue.TryDequeue(out ArraySegment<T> segment);

            return segment;
        }

        public void Return(ArraySegment<T> segment)
        {
            if (segment.Array != Array)
                throw new ArgumentException(nameof(segment));

            var bucket = _buckets[segment.Count];
            bucket.Queue.Enqueue(segment);
            bucket.Semaphore.Release();
        }
    }
}