namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5786)]
    public class ExchangeWaitingResultMessage
    {
        [RegularBool]
        public bool Bwait { get; set; }
    }
}