using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5907)]
    public class ExchangeShopStockMovementRemovedMessage
    {
        [CustomVar]
        public uint ObjectId { get; set; }
    }
}