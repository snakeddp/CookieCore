namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5578)]
    public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long PartyLeaderId { get; set; }
    }
}