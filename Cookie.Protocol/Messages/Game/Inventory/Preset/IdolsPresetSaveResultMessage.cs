
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6604)]
    public class IdolsPresetSaveResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }
    }
}
