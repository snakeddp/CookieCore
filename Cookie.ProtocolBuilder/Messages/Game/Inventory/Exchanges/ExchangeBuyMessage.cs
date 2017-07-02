namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5774)]
    public class ExchangeBuyMessage
    {
        [CustomVar]
        public uint ObjectToBuyId { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}