
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5794)]
    public class ExchangeCraftInformationObjectMessage : ExchangeCraftResultWithObjectIdMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
