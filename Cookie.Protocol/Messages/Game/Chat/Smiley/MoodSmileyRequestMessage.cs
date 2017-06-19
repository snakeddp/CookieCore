
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6192)]
    public class MoodSmileyRequestMessage
    {
        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}
