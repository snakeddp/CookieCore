using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(216)]
    public class FightResultMutantListEntry : FightResultFighterListEntry
    {
        [CustomVar]
        public ushort Level { get; set; }
    }
}