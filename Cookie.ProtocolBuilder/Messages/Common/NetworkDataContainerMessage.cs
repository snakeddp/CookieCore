namespace Cookie.Protocol.Messages.Common
{
    [NetworkMessage(2)]
    public class NetworkDataContainerMessage
    {
        [LengthType(typeof(int), true)]
        public sbyte[] Content { get; set; }
    }
}