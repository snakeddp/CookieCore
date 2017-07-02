using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3016)]
    public class InventoryContentMessage
    {
        [CustomVar]
        public long Kamas { get; set; }
    }
}