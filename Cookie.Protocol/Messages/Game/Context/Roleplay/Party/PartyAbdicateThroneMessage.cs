
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6080)]
    public class PartyAbdicateThroneMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
