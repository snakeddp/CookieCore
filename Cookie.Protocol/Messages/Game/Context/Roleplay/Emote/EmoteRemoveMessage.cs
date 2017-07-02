using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5687)]
    public class EmoteRemoveMessage
    {
        public sbyte EmoteId { get; set; }
    }
}