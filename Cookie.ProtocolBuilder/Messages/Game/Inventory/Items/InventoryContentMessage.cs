namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3016)]
    public class InventoryContentMessage
    {
        [CustomVar]
        public long Kamas { get; set; }
    }
}