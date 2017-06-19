namespace Cookie.IO.Interfaces
{
    public interface IWriter
    {
        byte[] Buffer { get; }
        int Length { get; }
        int Position { get; set; }
        int BytesAvailable { get; }

        void WriteValue<T>(T value);
        void WriteCustom<T>(T value);
        void WriteArray<T>(T[] value, int n);
        void WriteWrappedBool<T>(T value, int offset = 0, bool forceNewByte = false);
    }
}
