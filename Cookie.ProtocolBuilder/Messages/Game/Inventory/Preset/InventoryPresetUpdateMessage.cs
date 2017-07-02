namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6171)]
    public class InventoryPresetUpdateMessage
    {
        public Preset Preset { get; set; }
    }
}