using System;

namespace Cookie.Memory.Pooling.Array
{
    public interface IArrayPool<T>
    {
        ArraySegment<T> Take(int minSize);
        void Return(ArraySegment<T> segment);
    }
}