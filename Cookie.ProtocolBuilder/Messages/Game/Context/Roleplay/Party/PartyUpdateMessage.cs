using Cookie.Protocol.Types.Game.Context.Roleplay.Party;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5575)]
    public class PartyUpdateMessage : AbstractPartyEventMessage
    {
        public PartyMemberInformations MemberInformations { get; set; }
    }
}