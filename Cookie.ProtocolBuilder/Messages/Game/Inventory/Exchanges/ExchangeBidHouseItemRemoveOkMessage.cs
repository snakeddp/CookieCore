namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5946)]
    public class ExchangeBidHouseItemRemoveOkMessage
    {
        public int SellerId { get; set; }
    }
}