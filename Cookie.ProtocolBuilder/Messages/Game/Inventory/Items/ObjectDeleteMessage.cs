namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3022)]
    public class ObjectDeleteMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}