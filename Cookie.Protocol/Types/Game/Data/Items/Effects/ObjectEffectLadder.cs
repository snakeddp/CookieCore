using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(81)]
    public class ObjectEffectLadder : ObjectEffectCreature
    {
        [CustomVar]
        public uint MonsterCount { get; set; }
    }
}