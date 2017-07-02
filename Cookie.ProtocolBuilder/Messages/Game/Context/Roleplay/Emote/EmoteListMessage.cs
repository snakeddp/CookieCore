namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5689)]
    public class EmoteListMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] EmoteIds { get; set; }
    }
}