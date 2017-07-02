using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6614)]
    public class IdolsPresetUseResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] MissingIdols { get; set; }
    }
}