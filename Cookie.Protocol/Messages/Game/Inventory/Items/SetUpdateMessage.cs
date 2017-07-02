using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5503)]
    public class SetUpdateMessage
    {
        [CustomVar]
        public ushort SetId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] SetObjects { get; set; }
    }
}