
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Inventory.Preset;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6168)]
    public class InventoryPresetItemUpdateMessage
    {
        public sbyte PresetId { get; set; }
        public PresetItem PresetItem { get; set; }
    }
}
