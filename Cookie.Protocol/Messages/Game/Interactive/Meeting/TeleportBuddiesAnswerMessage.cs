using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6294)]
    public class TeleportBuddiesAnswerMessage
    {
        [RegularBool]
        public bool Accept { get; set; }
    }
}