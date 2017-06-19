
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6167)]
    public class InventoryPresetUseMessage
    {
        public sbyte PresetId { get; set; }
    }
}
