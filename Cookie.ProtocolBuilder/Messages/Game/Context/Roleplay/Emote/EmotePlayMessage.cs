namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5683)]
    public class EmotePlayMessage : EmotePlayAbstractMessage
    {
        public double ActorId { get; set; }
        public uint AccountId { get; set; }
    }
}