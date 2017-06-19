
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6519)]
    public class ObtainedItemMessage
    {
        [CustomVar]
        public ushort GenericId { get; set; }
        [CustomVar]
        public uint BaseQuantity { get; set; }
    }
}
