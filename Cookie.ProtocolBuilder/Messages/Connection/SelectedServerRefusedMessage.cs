namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(41)]
    public class SelectedServerRefusedMessage
    {
        [CustomVar]
        public ushort ServerId { get; set; }

        public sbyte Error { get; set; }
        public sbyte ServerStatus { get; set; }
    }
}