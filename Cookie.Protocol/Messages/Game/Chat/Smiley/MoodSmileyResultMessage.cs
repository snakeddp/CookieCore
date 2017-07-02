using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6196)]
    public class MoodSmileyResultMessage
    {
        public sbyte ResultCode { get; set; }

        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}