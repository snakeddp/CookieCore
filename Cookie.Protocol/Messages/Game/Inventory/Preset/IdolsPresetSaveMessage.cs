using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6603)]
    public class IdolsPresetSaveMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }
    }
}