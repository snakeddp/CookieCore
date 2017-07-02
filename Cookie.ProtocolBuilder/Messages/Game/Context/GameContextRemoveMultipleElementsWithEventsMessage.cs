namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(6416)]
    public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] ElementEventIds { get; set; }
    }
}