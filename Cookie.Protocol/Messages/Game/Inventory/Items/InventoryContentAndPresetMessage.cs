
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Inventory.Preset;
using Cookie.Protocol.Types.Game.Inventory.Preset;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6162)]
    public class InventoryContentAndPresetMessage : InventoryContentMessage
    {
    }
}
