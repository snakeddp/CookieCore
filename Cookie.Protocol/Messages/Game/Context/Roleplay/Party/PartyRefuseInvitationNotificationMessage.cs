
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5596)]
    public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long GuestId { get; set; }
    }
}
