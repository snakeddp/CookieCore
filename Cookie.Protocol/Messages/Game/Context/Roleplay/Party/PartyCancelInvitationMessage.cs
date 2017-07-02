using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6254)]
    public class PartyCancelInvitationMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long GuestId { get; set; }
    }
}