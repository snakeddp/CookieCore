
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6270)]
    public class PartyLoyaltyStatusMessage : AbstractPartyMessage
    {
        [RegularBool]
        public bool Loyal { get; set; }
    }
}
