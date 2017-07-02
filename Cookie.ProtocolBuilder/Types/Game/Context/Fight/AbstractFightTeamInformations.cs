namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(116)]
    public class AbstractFightTeamInformations
    {
        public sbyte TeamId { get; set; }
        public double LeaderId { get; set; }
        public byte TeamSide { get; set; }
        public sbyte TeamTypeId { get; set; }
        public sbyte NbWaves { get; set; }
    }
}