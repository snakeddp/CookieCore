namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(16)]
    public class FightResultListEntry
    {
        [CustomVar]
        public ushort Outcome { get; set; }

        public sbyte Wave { get; set; }
        public FightLoot Rewards { get; set; }
    }
}