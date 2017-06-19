
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5905)]
    public class ExchangeStartedBidSellerMessage
    {
        public SellerBuyerDescriptor SellerDescriptor { get; set; }
    }
}
