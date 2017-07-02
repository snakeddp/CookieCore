using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5644)]
    public class EmoteAddMessage
    {
        public sbyte EmoteId { get; set; }
    }
}