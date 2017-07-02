namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(6412)]
    public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
    {
        public sbyte ElementEventId { get; set; }
    }
}