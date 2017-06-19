
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Interactive;
using Cookie.Protocol.Types.Game.Interactive;

namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(80)]
    public class InteractiveElement
    {
        public uint ElementId { get; set; }
        public int ElementTypeId { get; set; }
        [RegularBool]
        public bool OnCurrentMap { get; set; }
    }
}
