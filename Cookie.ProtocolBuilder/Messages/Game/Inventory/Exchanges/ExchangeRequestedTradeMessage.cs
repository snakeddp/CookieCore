namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5523)]
    public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
    {
        [CustomVar]
        public long Source { get; set; }

        [CustomVar]
        public long Target { get; set; }
    }
}