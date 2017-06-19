
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6234)]
    public class ObjectUseMultipleMessage : ObjectUseMessage
    {
        [CustomVar]
        public uint Quantity { get; set; }
    }
}
