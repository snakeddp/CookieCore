namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5947)]
    public class ExchangeBidHouseGenericItemAddedMessage
    {
        [CustomVar]
        public ushort ObjGenericId { get; set; }
    }
}