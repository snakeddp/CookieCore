using Cookie.IO.Interfaces;

namespace Cookie.SerDes.Ser
{
    internal static class Helper
    {
        private static uint _instanceId;

        public static void WriteInstanceId(IWriter writer) => writer.WriteValue(_instanceId++);

        public static void WriteLen(IWriter writer, int typeLen, int length)
        {
            switch (typeLen)
            {
                case 1:
                    writer.WriteValue((byte) length);
                    break;
                case 2:
                    writer.WriteValue((short) length);
                    break;
                case 3:
                    writer.WriteValue((byte) ((length >> 16) & 255));
                    writer.WriteValue((short) (length & 65535));
                    break;
            }
        }
    }
}