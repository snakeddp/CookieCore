using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Inventory.Preset;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6606)]
    public class IdolsPresetUpdateMessage
    {
        public IdolsPreset IdolsPreset { get; set; }
    }
}