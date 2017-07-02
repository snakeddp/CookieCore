namespace Cookie.Protocol.Messages.Game.Actions
{
    [NetworkMessage(1001)]
    public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
    {
        public short WaitAckId { get; set; }
    }
}