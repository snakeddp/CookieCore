namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5690)]
    public class EmotePlayAbstractMessage
    {
        public sbyte EmoteId { get; set; }
        public double EmoteStartTime { get; set; }
    }
}