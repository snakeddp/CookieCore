
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5804)]
    public class ExchangeBidHouseBuyMessage
    {
        [CustomVar]
        public uint Uid { get; set; }
        [CustomVar]
        public uint Qty { get; set; }
        [CustomVar]
        public long Price { get; set; }
    }
}
