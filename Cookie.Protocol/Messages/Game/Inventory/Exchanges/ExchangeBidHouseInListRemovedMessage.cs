using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5950)]
    public class ExchangeBidHouseInListRemovedMessage
    {
        public int ItemUID { get; set; }
    }
}