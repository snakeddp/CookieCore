using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6269)]
    public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
    {
        [RegularBool]
        public bool Loyal { get; set; }
    }
}