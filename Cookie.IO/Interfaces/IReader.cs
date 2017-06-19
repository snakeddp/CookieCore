using Cookie.IO.Enums;

namespace Cookie.IO.Interfaces
{
    public interface IReader
    {
        byte[] Buffer { get; }
        int Position { get; set; }
        int BytesAvailable { get; }
        int Length { get; }

        T ReadValue<T>();
        T ReadCustom<T>();
        T ReadWrappedBool<T>(int offset = 0, bool forceNewByte = false);
        T[] ReadArray<T>(int n);

        string ReadString(StringType stringType, int n = 0);
    }
}
