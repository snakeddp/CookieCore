using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5761)]
    public class ExchangeStartOkNpcShopMessage
    {
        public double NpcSellerId { get; set; }

        [CustomVar]
        public ushort TokenId { get; set; }
    }
}