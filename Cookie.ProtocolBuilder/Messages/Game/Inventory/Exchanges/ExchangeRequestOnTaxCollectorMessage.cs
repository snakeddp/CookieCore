namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5779)]
    public class ExchangeRequestOnTaxCollectorMessage
    {
        public int TaxCollectorId { get; set; }
    }
}