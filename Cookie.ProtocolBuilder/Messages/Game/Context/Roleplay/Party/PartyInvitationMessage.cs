namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5586)]
    public class PartyInvitationMessage : AbstractPartyMessage
    {
        public sbyte PartyType { get; set; }
        public string PartyName { get; set; }
        public sbyte MaxParticipants { get; set; }

        [CustomVar]
        public long FromId { get; set; }

        public string FromName { get; set; }

        [CustomVar]
        public long ToId { get; set; }
    }
}