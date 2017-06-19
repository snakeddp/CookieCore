
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Inventory.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(5646)]
    public class StorageInventoryContentMessage : InventoryContentMessage
    {
    }
}
