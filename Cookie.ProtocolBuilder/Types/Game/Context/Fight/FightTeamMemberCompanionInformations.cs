namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(451)]
    public class FightTeamMemberCompanionInformations : FightTeamMemberInformations
    {
        public sbyte CompanionId { get; set; }
        public sbyte Level { get; set; }
        public double MasterId { get; set; }
    }
}