
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(218)]
    public class HouseInformationsInside : HouseInformations
    {
        public uint InstanceId { get; set; }
        [RegularBool]
        public bool SecondHand { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        [CustomVar]
        public long Price { get; set; }
        [RegularBool]
        public bool IsLocked { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
    }
}
