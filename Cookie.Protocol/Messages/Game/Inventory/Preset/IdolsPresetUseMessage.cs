
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6615)]
    public class IdolsPresetUseMessage
    {
        public sbyte PresetId { get; set; }
        [RegularBool]
        public bool Party { get; set; }
    }
}
