
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(5645)]
    public class StorageKamasUpdateMessage
    {
        [CustomVar]
        public long KamasTotal { get; set; }
    }
}
