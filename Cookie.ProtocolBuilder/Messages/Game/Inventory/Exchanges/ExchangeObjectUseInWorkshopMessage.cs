namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6004)]
    public class ExchangeObjectUseInWorkshopMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public int Quantity { get; set; }
    }
}