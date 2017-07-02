namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(216)]
    public class FightResultMutantListEntry : FightResultFighterListEntry
    {
        [CustomVar]
        public ushort Level { get; set; }
    }
}