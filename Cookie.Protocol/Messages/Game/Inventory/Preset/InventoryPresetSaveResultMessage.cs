using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6170)]
    public class InventoryPresetSaveResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }
    }
}