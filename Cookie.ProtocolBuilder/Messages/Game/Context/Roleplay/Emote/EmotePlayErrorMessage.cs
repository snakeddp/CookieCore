namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5688)]
    public class EmotePlayErrorMessage
    {
        public sbyte EmoteId { get; set; }
    }
}