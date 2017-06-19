
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6464)]
    public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
    {
        [RegularBool]
        public bool AllIdentical { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] MinimalPrices { get; set; }
    }
}
