using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5785)]
    public class ExchangeStartOkNpcTradeMessage
    {
        public double NpcId { get; set; }
    }
}