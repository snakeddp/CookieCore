namespace Cookie.Protocol.Messages.Security
{
    [NetworkMessage(6154)]
    public class CheckFileRequestMessage
    {
        public string Filename { get; set; }
        public sbyte Type { get; set; }
    }
}