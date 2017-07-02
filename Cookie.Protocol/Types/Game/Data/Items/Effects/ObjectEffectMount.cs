using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(179)]
    public class ObjectEffectMount : ObjectEffect
    {
        public uint MountId { get; set; }
        public double Date { get; set; }

        [CustomVar]
        public ushort ModelId { get; set; }
    }
}