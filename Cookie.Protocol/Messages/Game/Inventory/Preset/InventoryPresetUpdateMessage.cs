using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6171)]
    public class InventoryPresetUpdateMessage
    {
        public Types.Game.Inventory.Preset.Preset Preset { get; set; }
    }
}