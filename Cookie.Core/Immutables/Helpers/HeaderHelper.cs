namespace Cookie.Core.Helpers
{
    public static class HeaderHelper
    {
        public static int SizeOfLength(int len)
        {
            if (len > ushort.MaxValue)
                return 3;
            if (len > byte.MaxValue)
                return 2;
            return len > 0 ? 1 : 0;
        }

        public static short SubComputeStaticHeader(short id, int typeLen) => (short)(id << 2 | typeLen);
    }
}
