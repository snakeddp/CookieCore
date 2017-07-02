namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5948)]
    public class ExchangeBidHouseGenericItemRemovedMessage
    {
        [CustomVar]
        public ushort ObjGenericId { get; set; }
    }
}