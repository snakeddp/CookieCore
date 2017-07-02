using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6065)]
    public class LivingObjectMessageMessage
    {
        [CustomVar]
        public ushort MsgId { get; set; }

        public uint TimeStamp { get; set; }
        public string Owner { get; set; }

        [CustomVar]
        public ushort ObjectGenericId { get; set; }
    }
}