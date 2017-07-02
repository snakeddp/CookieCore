using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5787)]
    public class ExchangeReplyTaxVendorMessage
    {
        [CustomVar]
        public long ObjectValue { get; set; }

        [CustomVar]
        public long TotalTaxValue { get; set; }
    }
}