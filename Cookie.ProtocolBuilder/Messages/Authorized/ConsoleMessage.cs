namespace Cookie.Protocol.Messages.Authorized
{
    [NetworkMessage(75)]
    public class ConsoleMessage
    {
        public sbyte Type { get; set; }
        public string Content { get; set; }
    }
}