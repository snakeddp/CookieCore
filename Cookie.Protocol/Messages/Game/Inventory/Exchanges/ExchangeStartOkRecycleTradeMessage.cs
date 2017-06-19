
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6600)]
    public class ExchangeStartOkRecycleTradeMessage
    {
        public ushort PercentToPrism { get; set; }
        public ushort PercentToPlayer { get; set; }
    }
}
