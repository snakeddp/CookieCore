namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5517)]
    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}