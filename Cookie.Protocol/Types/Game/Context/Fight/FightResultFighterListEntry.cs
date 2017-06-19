
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(189)]
    public class FightResultFighterListEntry : FightResultListEntry
    {
        public double Id { get; set; }
        [RegularBool]
        public bool Alive { get; set; }
    }
}
