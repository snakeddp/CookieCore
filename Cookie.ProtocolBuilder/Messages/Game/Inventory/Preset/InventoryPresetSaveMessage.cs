namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6165)]
    public class InventoryPresetSaveMessage : AbstractPresetSaveMessage
    {
        [RegularBool]
        public bool SaveEquipment { get; set; }
    }
}