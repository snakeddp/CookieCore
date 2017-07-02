using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(511)]
    public class HouseInstanceInformations
    {
        public uint InstanceId { get; set; }
        public bool SecondHand { get; set; }
        public string OwnerName { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsSaleLocked { get; set; }
    }
}