namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5592)]
    public class PartyKickRequestMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}