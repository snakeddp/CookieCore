using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6256)]
    public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long CancelerId { get; set; }
    }
}