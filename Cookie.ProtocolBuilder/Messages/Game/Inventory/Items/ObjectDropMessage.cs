namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3005)]
    public class ObjectDropMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}