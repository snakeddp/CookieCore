
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3024)]
    public class ObjectDeletedMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}
