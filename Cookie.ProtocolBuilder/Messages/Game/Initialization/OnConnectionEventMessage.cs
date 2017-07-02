namespace Cookie.Protocol.Messages.Game.Initialization
{
    [NetworkMessage(5726)]
    public class OnConnectionEventMessage
    {
        public sbyte EventType { get; set; }
    }
}