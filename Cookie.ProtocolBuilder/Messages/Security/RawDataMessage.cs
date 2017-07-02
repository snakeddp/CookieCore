namespace Cookie.Protocol.Messages.Security
{
    [NetworkMessage(6253)]
    public class RawDataMessage
    {
        [LengthType(typeof(int), true)]
        public sbyte[] Content { get; set; }
    }
}