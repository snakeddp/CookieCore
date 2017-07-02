namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5590)]
    public class PartyKickedByMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long KickerId { get; set; }
    }
}