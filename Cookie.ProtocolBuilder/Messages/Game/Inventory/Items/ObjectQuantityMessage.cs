namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3023)]
    public class ObjectQuantityMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}