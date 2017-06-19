
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items;

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
