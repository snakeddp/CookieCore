
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5588)]
    public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
    {
        [RegularBool]
        public bool Enabled { get; set; }
    }
}
