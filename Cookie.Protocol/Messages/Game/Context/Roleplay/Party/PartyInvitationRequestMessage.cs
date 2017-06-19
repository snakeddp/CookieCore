
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5585)]
    public class PartyInvitationRequestMessage
    {
        public string Name { get; set; }
    }
}
