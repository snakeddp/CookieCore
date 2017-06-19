
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6165)]
    public class InventoryPresetSaveMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }
        [RegularBool]
        public bool SaveEquipment { get; set; }
    }
}
