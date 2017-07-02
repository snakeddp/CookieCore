using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6596)]
    public class ChatSmileyExtraPackListMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] PackIds { get; set; }
    }
}