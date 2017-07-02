namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6589)]
    public class ExchangeStoppedMessage
    {
        [CustomVar]
        public long Id { get; set; }
    }
}