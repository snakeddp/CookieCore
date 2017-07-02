using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(71)]
    public class ObjectEffectCreature : ObjectEffect
    {
        [CustomVar]
        public ushort MonsterFamilyId { get; set; }
    }
}