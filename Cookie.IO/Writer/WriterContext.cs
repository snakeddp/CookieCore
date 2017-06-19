using System;
using Cookie.Core.Immutables;
using Cookie.IO.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.IO.Writer
{
    public unsafe class WriterContext : IWriter
    {
        private readonly byte* _startPtr;
        private readonly int _endPtr;
        internal byte* CurrentPtr;
        private readonly FastBinaryWriter _bw;

        /// <summary>
        /// Get the buffer from the writer.
        /// </summary>
        public byte[] Buffer { get; }

        /// <summary>
        /// Get or set the position in the current buffer.
        /// </summary>
        /// <remarks>
        /// If you are inside a <see cref="WriterContext"/>, set this position doesn't change anything. 
        /// You have to set the position of the <see cref="WriterContext"/> 
        /// instead of the <see cref="FastBinaryWriter"/>'s position.
        /// </remarks>
        public int Position
        {
            get => (int)CurrentPtr - (int)_startPtr;
            set
            {
                if (value < 0 || value + (int)CurrentPtr > _endPtr)
                    throw new ArgumentOutOfRangeException(nameof(value));
                CurrentPtr = _startPtr + value;
            }
        }

        /// <summary>
        /// The length of the current buffer. This may be smaller than the real length.
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// The number of bytes available to write.
        /// </summary>
        public int BytesAvailable => _endPtr - (int)CurrentPtr;

        internal WriterContext(byte* pSrc, FastBinaryWriter bw)
        {
            _bw = bw;
            CurrentPtr = pSrc;
            _startPtr = pSrc - bw.Position;
            _endPtr = (int)_startPtr + bw.Length;
            Buffer = bw.Buffer;
            Length = bw.Length;
        }

        internal void UpdatePosition() => _bw.Position = (int)CurrentPtr - (int)_startPtr;

        /// <summary>
        /// Write a <see cref="T"/> into the buffer and set the position.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="byte"/>, <see cref="sbyte"/>, <see cref="bool"/>, <see cref="short"/>, 
        /// <see cref="ushort"/>, <see cref="int"/>, <see cref="uint"/>, <see cref="long"/>, 
        /// <see cref="ulong"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>, 
        /// <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The value to write in</param>
        /// <remarks>
        /// </remarks>
        public void WriteValue<T>(T value)
        {
            if (PrimitiveTypes.Primitives.Contains(typeof(T)))
                if (BytesAvailable < SizeMapperManager.SizeOf<T>())
                    throw new ArgumentOutOfRangeException(nameof(T));

            WriterCache<T>.SingleWriteValue(CurrentPtr, value);
            CurrentPtr += value is string
                ? SizeMapperManager.SizeOf(value)
                : SizeMapperManager.SizeOf<T>();
        }

        /// <summary>
        /// Write a custom <see cref="T"/> into the buffer and set the position.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="short"/>, <see cref="int"/>, <see cref="long"/>, 
        /// <see cref="ulong"/>
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The value to write in</param>
        /// <remarks>
        /// </remarks>
        public void WriteCustom<T>(T value)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf(value))
                throw new ArgumentOutOfRangeException();

            WriterCache<T>.SingleWriteCustom(CurrentPtr, value);
            CurrentPtr += SizeMapperManager.SizeOf(value);
        }

        /// <summary>
        /// Write an array of <see cref="T"/> into the buffer and set the position.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="byte"/>, <see cref="sbyte"/>
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="values">The values to write in</param>
        /// <param name="n">The number of elements to write in</param>
        /// <remarks>
        /// </remarks>
        public void WriteArray<T>(T[] values, int n)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf<T>() * n)
                throw new ArgumentOutOfRangeException();

            WriterCache<T>.ArrayWrite(CurrentPtr, values, n);
            CurrentPtr += SizeMapperManager.SizeOf<T>() * n;
        }

        /// <summary>
        /// Write a <see cref="byte"/> of wrapped booleans into the buffer and set the position.
        /// <see cref="T"/> can only be a struct :
        /// <see cref="bool"/>
        /// </summary>
        /// <typeparam name="T">Type to write.</typeparam>
        /// <param name="value">The values to write in</param>
        /// <param name="offset">The offset to write in a byte (must be lesser than 8)</param>
        /// <param name="forceNewByte">Create a new wrapped boolean byte on true</param>
        /// <remarks>
        /// </remarks>
        public void WriteWrappedBool<T>(T value, int offset = 0, bool forceNewByte = false)
        {
            if (_bw.CurrentWrappedBooleanOffset > 7)
                forceNewByte = true;
            if (offset > 0)
                _bw.CurrentWrappedBooleanOffset = offset;
            if (forceNewByte || !_bw.IsByteAlreadyWritten)
            {
                _bw.CurrentWrappedBooleanByte = Buffer[Position];
                _bw.CurrentWrappedBooleanBytePosition = Position;
                _bw.CurrentWrappedBooleanOffset = 0;
                _bw.IsByteAlreadyWritten = true;
                // Don't need to write empty ,
                // just increment the position and replace the byte directly
                CurrentPtr++;
            }

            _bw.CurrentWrappedBooleanByte = WriterCache<T>.SingleWrapBoolean(value, _bw.CurrentWrappedBooleanByte, _bw.CurrentWrappedBooleanOffset);

            Buffer[_bw.CurrentWrappedBooleanBytePosition] = _bw.CurrentWrappedBooleanByte;
            _bw.CurrentWrappedBooleanOffset++;
        }
    }
}
