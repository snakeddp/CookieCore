
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Look
{
    [NetworkType(55)]
    public class EntityLook
    {
        [CustomVar]
        public ushort BonesId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Skins { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] IndexedColors { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public short[] Scales { get; set; }
    }
}
