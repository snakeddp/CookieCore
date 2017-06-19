using System;
using Cookie.IO.Enums;
using Cookie.IO.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.IO.Reader
{
    public class FastBinaryReader : IReader
    {
        static FastBinaryReader()
        {
            ReaderCache.Init();
        }

        /// <summary>
        /// Get the buffer from the reader.
        /// </summary>
        public byte[] Buffer { get; }

        private int _position;

        /// <summary>
        /// Get or set the position in the current buffer.
        /// </summary>
        /// <remarks>
        /// If you are inside a <see cref="ReaderContext"/>, set this position doesn't change anything. 
        /// You have to set the position of the <see cref="ReaderContext"/> 
        /// instead of the <see cref="FastBinaryReader"/>'s position.
        /// </remarks>
        public int Position
        {
            get => _position;
            set
            {
                if (value < 0 || value > Length)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _position = value;
            }

        }

        /// <summary>
        /// The length of the current buffer. This may be smaller than the real length.
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// The number of bytes available to read.
        /// </summary>
        public int BytesAvailable => Length - Position;

        internal byte CurrentWrappedBooleanOffset;
        internal byte CurrentWrappedBooleanByte;
        internal bool IsWrappedByteRead;

        /// <summary>
        /// Create a <see cref="FastBinaryReader"/> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to read</param>
        /// <param name="length">The maximum length of the buffer that you need to read</param>
        public FastBinaryReader(byte[] buffer, int length)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (length < 1 || length > buffer.Length)
                throw new ArgumentOutOfRangeException(nameof(length));

            Buffer = buffer;
            Length = length;
        }

        /// <summary>
        /// Create a <see cref="FastBinaryReader"/> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to read</param>
        public FastBinaryReader(byte[] buffer) : this(buffer, buffer.Length)
        { }

        /// <summary>
        /// Create a <see cref="FastBinaryReader"/> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to read</param>
        public FastBinaryReader(ArraySegment<byte> buffer) : this(buffer.Array, buffer.Count)
        { }

        public unsafe void CreateContext(Action<IReader> act)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var ctx = new ReaderContext(pSrc, this);
                act(ctx);
                ctx.UpdatePosition();
            }
        }

        /// <summary>
        /// Create a <see cref="ReaderContext"/>
        /// </summary>
        /// <param name="act">Delegate used to read with the context</param>
        /// <returns>A <see cref="T"/> created with the value(s) you've read.</returns>
        /// <remarks>
        /// Context is useful when you have to read multiple values. 
        /// Faster than multiple calls of the Read methods of <see cref="FastBinaryReader"/>
        /// </remarks>
        public unsafe T CreateContext<T>(Func<ReaderContext, T> act)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var ctx = new ReaderContext(pSrc, this);
                var t = act(ctx);
                ctx.UpdatePosition();
                return t;
            }
        }

        /// <summary>
        /// Create a <see cref="ReaderContext"/>
        /// </summary>
        /// <param name="act">Delegate used to read with the context</param>
        /// <returns>A <see cref="T"/> array created with the value(s) you've read.</returns>
        /// <remarks>
        /// Context is useful when you have to read multiple values. 
        /// Faster than multiple calls of the Read methods of <see cref="FastBinaryReader"/>
        /// </remarks>
        public unsafe T[] CreateContext<T>(Func<ReaderContext, T[]> act)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var ctx = new ReaderContext(pSrc, this);
                var t = act(ctx);
                ctx.UpdatePosition();
                return t;
            }
        }

        /// <summary>
        /// Read a <see cref="T"/> from the buffer, set the position and return the result.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="byte"/>, <see cref="sbyte"/>, <see cref="bool"/>, <see cref="short"/>, 
        /// <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, 
        /// <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>, 
        /// <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public unsafe T ReadValue<T>()
        {
            if (typeof(T) != typeof(string))
                if (BytesAvailable < SizeMapperManager.SizeOf<T>())
                    throw new ArgumentOutOfRangeException();

            fixed (byte* pSrc = &Buffer[Position])
            {
                var r = ReaderCache<T>.SingleReadValue(pSrc);
                Position += r is string
                    ? SizeMapperManager.SizeOf(r)
                    : SizeMapperManager.SizeOf<T>();
                return r;
            }
        }

        public unsafe string ReadString(StringType stringType, int n = 0)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var r = ReaderCache<string>.SingleReadString(pSrc, stringType, n);
                Position += n != 0 ? r.Length : 2 + r.Length;
                return r;
            }
        }

        /// <summary>
        /// Read a custom <see cref="T"/> from the buffer, set the position and return the result.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="short"/>, <see cref="int"/>, <see cref="long"/>, 
        /// <see cref="ulong"/>
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public unsafe T ReadCustom<T>()
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var r = ReaderCache<T>.SingleReadCustom(pSrc);
                Position += SizeMapperManager.SizeOf(r);
                return r;
            }
        }

        /// <summary>
        /// Read an array of <see cref="T"/> from the buffer, set the position and return result.
        /// <see cref="T"/> can only be :
        /// <see cref="byte"/>, <see cref="sbyte"/>
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <param name="n">Number of elements</param>
        /// <returns>Values that have been read from the buffer</returns>
        public unsafe T[] ReadArray<T>(int n)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf<T>() * n)
                throw new ArgumentOutOfRangeException();


            fixed (byte* pSrc = &Buffer[Position])
            {
                var r = ReaderCache<T>.ArrayRead(pSrc, n);

                Position += SizeMapperManager.SizeOf<T>() * n;
                return r;
            }
        }

        /// <summary>
        /// Read a wrapped <see cref="bool"/> from the actual byte in memory or a new byte if empty, and return the result.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="bool"/>
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <param name="offset">The offset to read in a byte (must be lesser than 8)</param>
        /// <param name="forceNewByte">Read a new wrapped boolean byte on true</param>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public T ReadWrappedBool<T>(int offset = 0, bool forceNewByte = false)
        {
            if (CurrentWrappedBooleanOffset > 7)
                forceNewByte = true;
            if (offset > 0)
                CurrentWrappedBooleanOffset = (byte)offset;
            if (forceNewByte || !IsWrappedByteRead)
            {
                CurrentWrappedBooleanByte = ReadValue<byte>();
                CurrentWrappedBooleanOffset = 0;
                IsWrappedByteRead = true;
            }

            var r = ReaderCache<T>.SingleReadWrappedBool(CurrentWrappedBooleanByte, CurrentWrappedBooleanOffset);
            CurrentWrappedBooleanOffset++;
            return r;
        }
    }
}
