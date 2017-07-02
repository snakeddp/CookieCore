using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6010)]
    public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}