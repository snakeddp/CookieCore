
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6000)]
    public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
    {
        [CustomVar]
        public ushort ObjectGenericId { get; set; }
    }
}
