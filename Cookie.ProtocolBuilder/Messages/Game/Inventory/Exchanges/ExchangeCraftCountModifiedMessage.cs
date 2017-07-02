namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6595)]
    public class ExchangeCraftCountModifiedMessage
    {
        [CustomVar]
        public int Count { get; set; }
    }
}