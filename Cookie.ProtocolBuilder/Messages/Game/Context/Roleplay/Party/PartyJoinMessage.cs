namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5576)]
    public class PartyJoinMessage : AbstractPartyMessage
    {
        public sbyte PartyType { get; set; }

        [CustomVar]
        public long PartyLeaderId { get; set; }

        public sbyte MaxParticipants { get; set; }

        [RegularBool]
        public bool Restricted { get; set; }

        public string PartyName { get; set; }
    }
}