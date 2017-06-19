
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(205)]
    public class GameFightSpellCooldown
    {
        public int SpellId { get; set; }
        public sbyte Cooldown { get; set; }
    }
}
