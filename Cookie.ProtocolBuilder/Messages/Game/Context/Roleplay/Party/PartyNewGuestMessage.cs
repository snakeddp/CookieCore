using Cookie.Protocol.Types.Game.Context.Roleplay.Party;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6260)]
    public class PartyNewGuestMessage : AbstractPartyEventMessage
    {
        public PartyGuestInformations Guest { get; set; }
    }
}