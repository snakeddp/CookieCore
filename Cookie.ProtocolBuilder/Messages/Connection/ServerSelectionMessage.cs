namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(40)]
    public class ServerSelectionMessage
    {
        [CustomVar]
        public ushort ServerId { get; set; }
    }
}