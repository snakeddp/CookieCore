
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6329)]
    public class InventoryPresetSaveCustomMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }
        [LengthType(typeof(short), true)]
        public sbyte[] ItemsPositions { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ItemsUids { get; set; }
    }
}
