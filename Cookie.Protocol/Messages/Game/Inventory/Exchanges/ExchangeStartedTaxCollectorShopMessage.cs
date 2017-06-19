
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6664)]
    public class ExchangeStartedTaxCollectorShopMessage
    {
        [CustomVar]
        public long Kamas { get; set; }
    }
}
