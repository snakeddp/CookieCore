namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5520)]
    public class ExchangeObjectMoveKamaMessage
    {
        [CustomVar]
        public long Quantity { get; set; }
    }
}