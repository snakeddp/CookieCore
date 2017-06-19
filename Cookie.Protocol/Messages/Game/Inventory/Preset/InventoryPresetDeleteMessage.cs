
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6169)]
    public class InventoryPresetDeleteMessage
    {
        public sbyte PresetId { get; set; }
    }
}
