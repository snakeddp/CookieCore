
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(207)]
    public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
    {
        [CustomVar]
        public ushort BoostedSpellId { get; set; }
    }
}
