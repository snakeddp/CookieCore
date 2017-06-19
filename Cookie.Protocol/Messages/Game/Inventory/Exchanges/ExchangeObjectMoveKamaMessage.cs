
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5520)]
    public class ExchangeObjectMoveKamaMessage
    {
        [CustomVar]
        public long Quantity { get; set; }
    }
}
