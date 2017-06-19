
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Look
{
    [NetworkType(54)]
    public class SubEntity
    {
        public sbyte BindingPointCategory { get; set; }
        public sbyte BindingPointIndex { get; set; }
        public EntityLook SubEntityLook { get; set; }
    }
}
