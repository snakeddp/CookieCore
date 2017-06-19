
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(70)]
    public class ObjectEffectInteger : ObjectEffect
    {
        [CustomVar]
        public ushort Value { get; set; }
    }
}
