namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5949)]
    public class ExchangeBidHouseInListAddedMessage
    {
        public int ItemUID { get; set; }
        public int ObjGenericId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public long[] Prices { get; set; }
    }
}