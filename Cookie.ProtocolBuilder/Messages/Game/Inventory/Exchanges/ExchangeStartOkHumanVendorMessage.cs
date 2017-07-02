namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5767)]
    public class ExchangeStartOkHumanVendorMessage
    {
        public double SellerId { get; set; }
    }
}