
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(6727)]
    public class HouseSellingUpdateMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }
        public uint InstanceId { get; set; }
        [RegularBool]
        public bool SecondHand { get; set; }
        [CustomVar]
        public long RealPrice { get; set; }
        public string BuyerName { get; set; }
    }
}
