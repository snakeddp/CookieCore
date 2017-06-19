
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6670)]
    public class ExchangePodsModifiedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public uint CurrentWeight { get; set; }
        [CustomVar]
        public uint MaxWeight { get; set; }
    }
}
