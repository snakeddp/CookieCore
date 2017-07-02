namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5518)]
    public class ExchangeObjectMoveMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public int Quantity { get; set; }
    }
}