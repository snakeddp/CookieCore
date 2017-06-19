
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3016)]
    public class InventoryContentMessage
    {
        [CustomVar]
        public long Kamas { get; set; }
    }
}
