namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5805)]
    public class ExchangeBidHousePriceMessage
    {
        [CustomVar]
        public ushort GenId { get; set; }
    }
}