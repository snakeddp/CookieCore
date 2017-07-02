namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6010)]
    public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}