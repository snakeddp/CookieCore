using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6302)]
    public class TeleportBuddiesRequestedMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }

        [CustomVar]
        public long InviterId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public long[] InvalidBuddiesIds { get; set; }
    }
}