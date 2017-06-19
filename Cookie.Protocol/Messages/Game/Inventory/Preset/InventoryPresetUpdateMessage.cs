
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Inventory.Preset;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6171)]
    public class InventoryPresetUpdateMessage
    {
        public Types.Game.Inventory.Preset.Preset Preset { get; set; }
    }
}
