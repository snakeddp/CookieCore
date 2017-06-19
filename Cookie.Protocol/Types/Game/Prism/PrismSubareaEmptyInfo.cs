
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(438)]
    public class PrismSubareaEmptyInfo
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
        [CustomVar]
        public uint AllianceId { get; set; }
    }
}
