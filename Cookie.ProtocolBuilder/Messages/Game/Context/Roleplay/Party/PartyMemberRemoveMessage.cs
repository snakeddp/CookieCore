namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5579)]
    public class PartyMemberRemoveMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long LeavingPlayerId { get; set; }
    }
}