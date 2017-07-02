namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6272)]
    public class ExchangeBidHouseBuyResultMessage
    {
        [CustomVar]
        public uint Uid { get; set; }

        [RegularBool]
        public bool Bought { get; set; }
    }
}