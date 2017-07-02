using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6605)]
    public class IdolsPresetDeleteResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }
    }
}