namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5685)]
    public class EmotePlayRequestMessage
    {
        public sbyte EmoteId { get; set; }
    }
}