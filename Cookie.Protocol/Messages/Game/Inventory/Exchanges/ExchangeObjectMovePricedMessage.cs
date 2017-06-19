
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5514)]
    public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
    {
        [CustomVar]
        public long Price { get; set; }
    }
}
