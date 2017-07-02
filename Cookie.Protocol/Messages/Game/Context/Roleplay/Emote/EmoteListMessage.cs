using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5689)]
    public class EmoteListMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] EmoteIds { get; set; }
    }
}