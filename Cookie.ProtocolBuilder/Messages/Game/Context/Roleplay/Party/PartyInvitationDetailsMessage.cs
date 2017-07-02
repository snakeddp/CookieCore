namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6263)]
    public class PartyInvitationDetailsMessage : AbstractPartyMessage
    {
        public sbyte PartyType { get; set; }
        public string PartyName { get; set; }

        [CustomVar]
        public long FromId { get; set; }

        public string FromName { get; set; }

        [CustomVar]
        public long LeaderId { get; set; }
    }
}