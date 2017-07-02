namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party.Companion
{
    [NetworkType(452)]
    public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
    {
        [CustomVar]
        public ushort Initiative { get; set; }

        [CustomVar]
        public uint LifePoints { get; set; }

        [CustomVar]
        public uint MaxLifePoints { get; set; }

        [CustomVar]
        public ushort Prospecting { get; set; }

        public sbyte RegenRate { get; set; }
    }
}