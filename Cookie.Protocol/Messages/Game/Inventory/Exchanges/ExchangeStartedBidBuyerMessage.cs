using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5904)]
    public class ExchangeStartedBidBuyerMessage
    {
        public SellerBuyerDescriptor BuyerDescriptor { get; set; }
    }
}