
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5803)]
    public class ExchangeBidHouseTypeMessage
    {
        [CustomVar]
        public uint Type { get; set; }
    }
}
