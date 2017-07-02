namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5521)]
    public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public long Quantity { get; set; }
    }
}