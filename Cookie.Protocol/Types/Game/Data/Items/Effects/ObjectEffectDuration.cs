
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(75)]
    public class ObjectEffectDuration : ObjectEffect
    {
        [CustomVar]
        public ushort Days { get; set; }
        public sbyte Hours { get; set; }
        public sbyte Minutes { get; set; }
    }
}
