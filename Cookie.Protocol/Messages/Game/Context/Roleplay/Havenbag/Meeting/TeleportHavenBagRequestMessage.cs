using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6647)]
    public class TeleportHavenBagRequestMessage
    {
        [CustomVar]
        public long GuestId { get; set; }
    }
}