using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5517)]
    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}