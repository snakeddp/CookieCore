namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(115)]
    public class FightTeamLightInformations : AbstractFightTeamInformations
    {
        public sbyte TeamMembersCount { get; set; }

        [CustomVar]
        public uint MeanLevel { get; set; }

        public bool HasFriend { get; set; }
        public bool HasGuildMember { get; set; }
        public bool HasAllianceMember { get; set; }
        public bool HasGroupMember { get; set; }
        public bool HasMyTaxCollector { get; set; }
    }
}