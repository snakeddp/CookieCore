
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6287)]
    public class TeleportToBuddyOfferMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
        [CustomVar]
        public long BuddyId { get; set; }
        [CustomVar]
        public uint TimeLeft { get; set; }
    }
}
