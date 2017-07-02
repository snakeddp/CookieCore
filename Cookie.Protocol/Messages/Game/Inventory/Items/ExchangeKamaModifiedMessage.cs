using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5521)]
    public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public long Quantity { get; set; }
    }
}