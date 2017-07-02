namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6519)]
    public class ObtainedItemMessage
    {
        [CustomVar]
        public ushort GenericId { get; set; }

        [CustomVar]
        public uint BaseQuantity { get; set; }
    }
}