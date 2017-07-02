namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6579)]
    public class ExchangeCraftPaymentModificationRequestMessage
    {
        [CustomVar]
        public long Quantity { get; set; }
    }
}