namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6290)]
    public class ObjectFeedMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint FoodUID { get; set; }

        [CustomVar]
        public uint FoodQuantity { get; set; }
    }
}