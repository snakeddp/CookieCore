using System;
using Cookie.IO.Interfaces;

namespace Cookie.Network.Managers
{
    public static class MessageParser
    {
        public static bool TryParse(IReader reader, out int messageId, out int dataLength, out byte[] data)
        {
            messageId = 0;
            dataLength = 0;
            data = null;

            if (reader.BytesAvailable < 2)
                return false;

            var header = reader.ReadValue<short>();
            messageId = header >> 2;

            var dataLengthBytesCount = header & 0x3;

            if (reader.BytesAvailable >= dataLengthBytesCount)
            {
                if (dataLengthBytesCount < 0 || dataLengthBytesCount > 3)
                    throw new ArgumentOutOfRangeException(nameof(dataLengthBytesCount));

                for (var i = dataLengthBytesCount - 1; i >= 0; i--)
                    dataLength |= reader.ReadValue<byte>() << (i * 8);
            }

            if (dataLength <= 0) return false;
            if (dataLength > reader.BytesAvailable)
                return false;

            if (data == null && dataLength >= 0)
            {
                if (dataLength == 0)
                    data = new byte[0];

                // enough bytes in the buffer to build a complete message
                if (reader.BytesAvailable >= dataLength)
                    data = reader.ReadArray<byte>(dataLength);
                // not enough bytes, so we read what we can
                else if (dataLength > reader.BytesAvailable)
                    data = reader.ReadArray<byte>(reader.BytesAvailable);
            }
            //second case : the message was split and it missed some bytes
            if (data == null || dataLength == 0 || data.Length >= dataLength) return true;
            var bytesToRead = 0;

            // still miss some bytes ...
            if (data.Length + reader.BytesAvailable < dataLength)
                bytesToRead = reader.BytesAvailable;

            // there is enough bytes in the buffer to complete the message :)
            else if (data.Length + reader.BytesAvailable >= dataLength)
                bytesToRead = dataLength - data.Length;

            if (bytesToRead == 0) return true;
            var oldLength = data.Length;
            Array.Resize(ref data, data.Length + bytesToRead);
            Array.Copy(reader.ReadArray<byte>(bytesToRead), 0, data, oldLength, bytesToRead);

            return true;
        }
    }
}