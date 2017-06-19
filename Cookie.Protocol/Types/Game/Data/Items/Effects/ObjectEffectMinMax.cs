
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(82)]
    public class ObjectEffectMinMax : ObjectEffect
    {
        [CustomVar]
        public uint Min { get; set; }
        [CustomVar]
        public uint Max { get; set; }
    }
}
