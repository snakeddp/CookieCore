
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(5647)]
    public class StorageObjectUpdateMessage
    {
        public ObjectItem Object { get; set; }
    }
}
