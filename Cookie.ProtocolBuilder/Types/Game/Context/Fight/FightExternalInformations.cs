namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(117)]
    public class FightExternalInformations
    {
        public int FightId { get; set; }
        public sbyte FightType { get; set; }
        public uint FightStart { get; set; }

        [RegularBool]
        public bool FightSpectatorLocked { get; set; }
    }
}