
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(108)]
    public class StatedElement
    {
        public uint ElementId { get; set; }
        [CustomVar]
        public ushort ElementCellId { get; set; }
        [CustomVar]
        public uint ElementState { get; set; }
        [RegularBool]
        public bool OnCurrentMap { get; set; }
    }
}
