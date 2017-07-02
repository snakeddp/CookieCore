using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5945)]
    public class ExchangeBidHouseItemAddOkMessage
    {
        public ObjectItemToSellInBid ItemInfo { get; set; }
    }
}