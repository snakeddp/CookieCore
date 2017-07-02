using System;
using Cookie.IO.Enums;
using Cookie.IO.Interfaces;
using Cookie.Sizeable.Managers;

namespace Cookie.IO.Reader
{
    public unsafe class ReaderContext : IReader
    {
        private readonly FastBinaryReader _br;
        private readonly int _endPtr;
        private readonly byte* _startPtr;
        internal byte* CurrentPtr;

        internal ReaderContext(byte* pSrc, FastBinaryReader br)
        {
            _br = br;
            CurrentPtr = pSrc;
            _startPtr = pSrc - br.Position;
            _endPtr = (int) _startPtr + br.Length;
            Buffer = br.Buffer;
            Length = br.Length;
        }

        /// <summary>
        ///     Get the buffer from the reader.
        /// </summary>
        public byte[] Buffer { get; }

        /// <summary>
        ///     Get or set the position in the current buffer.
        /// </summary>
        /// <remarks>
        ///     If you are inside a <see cref="ReaderContext" />, set this position doesn't change anything.
        ///     You have to set the position of the <see cref="ReaderContext" />
        ///     instead of the <see cref="FastBinaryReader" />'s position.
        /// </remarks>
        public int Position
        {
            get => (int) CurrentPtr - (int) _startPtr;
            set
            {
                if (value < 0 || value + (int) CurrentPtr > _endPtr)
                    throw new ArgumentOutOfRangeException(nameof(value));
                CurrentPtr = _startPtr + value;
            }
        }

        /// <summary>
        ///     The length of the current buffer. This may be smaller than the real length.
        /// </summary>
        public int Length { get; }

        /// <summary>
        ///     The number of bytes available to read.
        /// </summary>
        public int BytesAvailable => _endPtr - (int) CurrentPtr;

        /// <summary>
        ///     Read a <see cref="T" /> from the buffer, set the position and return the result.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="byte" />, <see cref="sbyte" />, <see cref="bool" />, <see cref="short" />,
        ///     <see cref="ushort" />, <see cref="int" />, <see cref="uint" />, <see cref="long" />,
        ///     <see cref="ulong" />, <see cref="float" />, <see cref="double" />, <see cref="decimal" />,
        ///     <see cref="string" />
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public T ReadValue<T>()
        {
            var r = ReaderCache<T>.SingleReadValue(CurrentPtr);

            CurrentPtr += r is string
                ? SizeMapperManager.SizeOf(r)
                : SizeMapperManager.SizeOf<T>();

            return r;
        }

        public string ReadString(StringType stringType, int n = 0)
        {
            fixed (byte* pSrc = &Buffer[Position])
            {
                var r = ReaderCache<string>.SingleReadString(pSrc, stringType, n);
                Position += n != 0 ? r.Length : 2 + r.Length;
                return r;
            }
        }

        /// <summary>
        ///     Read a custom <see cref="T" /> from the buffer, set the position and return the result.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="short" />, <see cref="ushort" />, <see cref="int" />, <see cref="uint" />,
        ///     <see cref="long" />, <see cref="ulong" />
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public T ReadCustom<T>()
        {
            var readValue = ReaderCache<T>.SingleReadCustom(CurrentPtr);
            CurrentPtr += SizeMapperManager.SizeOf(readValue);

            if (BytesAvailable < SizeMapperManager.SizeOf(readValue))
                throw new ArgumentOutOfRangeException(nameof(readValue));

            return readValue;
        }

        /// <summary>
        ///     Read an array of <see cref="T" /> from the buffer, set the position and return result.
        ///     <see cref="T" /> can only be :
        ///     <see cref="byte" />, <see cref="sbyte" />
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <param name="length">Number of elements</param>
        /// <returns>Values that have been read from the buffer</returns>
        public T[] ReadArray<T>(int length)
        {
            if (BytesAvailable < SizeMapperManager.SizeOf<T>() * length)
                throw new ArgumentOutOfRangeException(nameof(length));

            var r = ReaderCache<T>.ArrayRead(CurrentPtr, length);
            CurrentPtr += SizeMapperManager.SizeOf<T>() * length;
            return r;
        }

        /// <summary>
        ///     Read a wrapped <see cref="bool" /> from the actual byte in memory or a new byte if empty, and return the result.
        ///     <see cref="T" /> can only be a struct :
        ///     <see cref="bool" />
        /// </summary>
        /// <typeparam name="T">Type to read.</typeparam>
        /// <param name="offset">The offset to read in a byte (must be lesser than 8)</param>
        /// <param name="forceNewByte">Read a new wrapped boolean byte on true</param>
        /// <returns>Value that have been read from the buffer</returns>
        /// <remarks>
        /// </remarks>
        public T ReadWrappedBool<T>(int offset, bool forceNewByte)
        {
            if (_br.CurrentWrappedBooleanOffset > 7)
                forceNewByte = true;
            if (offset > 0)
                _br.CurrentWrappedBooleanOffset = (byte) offset;
            if (forceNewByte || !_br.IsWrappedByteRead)
            {
                _br.CurrentWrappedBooleanByte = ReadValue<byte>();
                _br.CurrentWrappedBooleanOffset = 0;
                _br.IsWrappedByteRead = true;
            }

            var r = ReaderCache<T>.SingleReadWrappedBool(_br.CurrentWrappedBooleanByte,
                _br.CurrentWrappedBooleanOffset);
            _br.CurrentWrappedBooleanOffset++;
            return r;
        }

        internal void UpdatePosition()
        {
            _br.Position = Position;
        }
    }
}