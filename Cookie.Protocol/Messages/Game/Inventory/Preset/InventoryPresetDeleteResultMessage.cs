using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6173)]
    public class InventoryPresetDeleteResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }
    }
}