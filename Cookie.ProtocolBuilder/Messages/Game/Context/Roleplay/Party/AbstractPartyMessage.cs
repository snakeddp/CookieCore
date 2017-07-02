namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6274)]
    public class AbstractPartyMessage
    {
        [CustomVar]
        public uint PartyId { get; set; }
    }
}