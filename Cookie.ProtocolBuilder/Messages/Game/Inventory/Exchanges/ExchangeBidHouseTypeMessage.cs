namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5803)]
    public class ExchangeBidHouseTypeMessage
    {
        [CustomVar]
        public uint Type { get; set; }
    }
}