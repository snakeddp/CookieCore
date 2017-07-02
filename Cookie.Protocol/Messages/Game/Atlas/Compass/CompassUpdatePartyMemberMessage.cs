using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Atlas.Compass
{
    [NetworkMessage(5589)]
    public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
    {
        [CustomVar]
        public long MemberId { get; set; }

        [RegularBool]
        public bool Active { get; set; }
    }
}