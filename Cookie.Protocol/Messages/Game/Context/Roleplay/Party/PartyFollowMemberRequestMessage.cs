
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5577)]
    public class PartyFollowMemberRequestMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
