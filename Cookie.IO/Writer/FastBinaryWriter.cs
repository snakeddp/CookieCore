using System;
using Cookie.IO.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.IO.Writer
{
    public class FastBinaryWriter : IWriter
    {
        private int _position;

        internal byte CurrentWrappedBooleanByte;
        internal int CurrentWrappedBooleanBytePosition;
        internal int CurrentWrappedBooleanOffset;
        internal bool IsByteAlreadyWritten;

        static FastBinaryWriter()
        {
            WriterCache.Init();
        }

        /// <summary>
        ///     Create a <see cref="FastBinaryWriter" /> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to write in</param>
        public FastBinaryWriter(ArraySegment<byte> buffer) : this(buffer.Array, buffer.Count)
        {
        }

        /// <summary>
        ///     Create a <see cref="FastBinaryWriter" /> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to write in</param>
        public FastBinaryWriter(byte[] buffer) : this(buffer, buffer.Length)
        {
        }

        /// <summary>
        ///     Create a <see cref="FastBinaryWriter" /> with the buffer specified and its length.
        /// </summary>
        /// <param name="buffer">The buffer to write in</param>
        /// <param name="length">The maximum length of the buffer that you have to write in</param>
        public FastBinaryWriter(byte[] buffer, int length)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (length < 1 || length > buffer.Length)
                throw new ArgumentOutOfRangeException(nameof(length));

            Buffer = buffer;
            Length = length;
        }

        /// <summary>
        ///     Create a <see cref="FastBinaryWriter" /> with length specified for the buffer.
        /// </summary>
        /// <param name="length">The maximum length of the buffer that you have to write in</param>
        public FastBinaryWriter(int length)
        {
            if (length < 1)
                throw new ArgumentNullException(nameof(length));

            Length = length;
            Buffer = new byte[Length];
        }

        /// <summary>
        ///     Get the buffer from the writer.
        /// </summary>
        public byte[] Buffer { get; }

        /// <summary>
        ///     Get or set the position in the current buffer.
        /// </summary>
        /// <remarks>
        ///     If you are inside a <see cref="WriterContext" />, set this position doesn't change anything.
        ///     You have to set the position of the <see cref="WriterContext" />
        ///     instead of the <see cref="FastBinaryWriter" />'s position.
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
        ///     The length of the current buffer. This may be smaller than the real length.
        /// </summary>
        public int Length { get; }

        /// <summary>
        ///     The number of bytes available to write.
        /// </summary>
        public int BytesAvailable => Length - Position;

        /// <summary>
        ///     Write a <see cref="T" /> into the buffer and set the position.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="byte" />, <see cref="sbyte" />, <see cref="bool" />, <see cref="short" />,
        ///     <see cref="ushort" />, <see cref="int" />, <see cref="uint" />, <see cref="long" />,
        ///     <see cref="ulong" />, <see cref="float" />, <see cref="double" />, <see cref="decimal" />,
        ///     <see cref="string" />
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The value to write in</param>
        /// <remarks>
        /// </remarks>
        public unsafe void WriteValue<T>(T value)
        {
            if (typeof(T) != typeof(string))
                if (BytesAvailable < SizeMapperManager.SizeOf<T>())
                    throw new ArgumentOutOfRangeException();

            fixed (byte* pSrc = &Buffer[Position])
            {
                WriterCache<T>.SingleWriteValue(pSrc, value);
                Position += value is string
                    ? SizeMapperManager.SizeOf(value)
                    : SizeMapperManager.SizeOf<T>();
            }
        }

        /// <summary>
        ///     Write a custom <see cref="T" /> into the buffer and set the position.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="short" />, <see cref="int" />, <see cref="long" />,
        ///     <see cref="ulong" />
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The value to write in</param>
        /// <remarks>
        /// </remarks>
        public unsafe void WriteCustom<T>(T value)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf(value))
                throw new ArgumentOutOfRangeException();

            fixed (byte* pSrc = &Buffer[Position])
            {
                WriterCache<T>.SingleWriteCustom(pSrc, value);
                Position += SizeMapperManager.SizeOf(value);
            }
        }

        /// <summary>
        ///     Write an array of <see cref="T" /> into the buffer and set the position.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="byte" />, <see cref="sbyte" />
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="values">The values to write in</param>
        /// <param name="n">The number of elements to write in</param>
        /// <remarks>
        /// </remarks>
        public unsafe void WriteArray<T>(T[] values, int n)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf<T>() * n)
                throw new ArgumentOutOfRangeException();

            fixed (byte* pSrc = &Buffer[Position])
            {
                WriterCache<T>.ArrayWrite(pSrc, values, n);
                Position += SizeMapperManager.SizeOf<T>() * n;
            }
        }

        /// <summary>
        ///     Write a <see cref="byte" /> of wrapped booleans into the buffer and set the position.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="bool" />
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The values to write in</param>
        /// <param name="offset">The offset to write in a byte (must be lesser than 8)</param>
        /// <param name="forceNewByte">Create a new wrapped boolean byte on true</param>
        /// <remarks>
        /// </remarks>
        public void WriteWrappedBool<T>(T value, int offset = 0, bool forceNewByte = false)
        {
            if (CurrentWrappedBooleanOffset > 7)
                forceNewByte = true;
            if (offset > 0)
                CurrentWrappedBooleanOffset = offset;
            if (forceNewByte || !IsByteAlreadyWritten)
            {
                CurrentWrappedBooleanByte = Buffer[Position];
                CurrentWrappedBooleanBytePosition = Position;
                CurrentWrappedBooleanOffset = 0;
                IsByteAlreadyWritten = true;
                // Don't need to write empty ,
                // just increment the position and replace the byte directly
                Position++;
            }

            CurrentWrappedBooleanByte =
                WriterCache<T>.SingleWrapBoolean(value, CurrentWrappedBooleanByte, CurrentWrappedBooleanOffset);

            Buffer[CurrentWrappedBooleanBytePosition] = CurrentWrappedBooleanByte;
            CurrentWrappedBooleanOffset++;
        }

        /// <summary>
        ///     Create a <see cref="WriterContext" />
        /// </summary>
        /// <param name="act">Delegate used to write with the context</param>
        /// <remarks>
        ///     Context is useful when you have to write multiple values.
        ///     Faster than multiple calls of the Write methods of <see cref="FastBinaryWriter" />
        /// </remarks>
        public unsafe void CreateContext(Action<WriterContext> act)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var ctx = new WriterContext(pSrc, this);
                act(ctx);
                ctx.UpdatePosition();
            }
        }
    }
}