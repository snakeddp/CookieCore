
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.House
{
    [NetworkMessage(6726)]
    public class HouseTeleportRequestMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }
        public int HouseInstanceId { get; set; }
    }
}
