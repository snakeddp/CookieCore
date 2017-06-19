
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.House;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(390)]
    public class AccountHouseInformations : HouseInformations
    {
        public HouseInstanceInformations HouseInfos { get; set; }
        [CustomVar]
        public long RealPrice { get; set; }
        [RegularBool]
        public bool IsLocked { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }
        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}
