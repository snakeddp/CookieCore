using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5578)]
    public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long PartyLeaderId { get; set; }
    }
}