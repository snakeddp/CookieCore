namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5810)]
    public class ExchangeItemAutoCraftStopedMessage
    {
        public byte Reason { get; set; }
    }
}