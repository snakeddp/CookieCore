using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6211)]
    public class InventoryPresetItemUpdateErrorMessage
    {
        public sbyte Code { get; set; }
    }
}