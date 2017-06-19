
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(111)]
    public class HouseInformations
    {
        [CustomVar]
        public uint HouseId { get; set; }
        [CustomVar]
        public ushort ModelId { get; set; }
    }
}
