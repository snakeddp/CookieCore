
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6210)]
    public class InventoryPresetItemUpdateRequestMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Position { get; set; }
        [CustomVar]
        public uint ObjUid { get; set; }
    }
}
