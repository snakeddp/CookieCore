namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6664)]
    public class ExchangeStartedTaxCollectorShopMessage
    {
        [CustomVar]
        public long Kamas { get; set; }
    }
}