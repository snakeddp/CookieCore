using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6602)]
    public class IdolsPresetDeleteMessage
    {
        public sbyte PresetId { get; set; }
    }
}