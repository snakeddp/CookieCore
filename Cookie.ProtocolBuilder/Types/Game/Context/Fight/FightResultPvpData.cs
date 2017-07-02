namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(190)]
    public class FightResultPvpData : FightResultAdditionalData
    {
        public sbyte Grade { get; set; }

        [CustomVar]
        public ushort MinHonorForGrade { get; set; }

        [CustomVar]
        public ushort MaxHonorForGrade { get; set; }

        [CustomVar]
        public ushort Honor { get; set; }

        [CustomVar]
        public short HonorDelta { get; set; }
    }
}