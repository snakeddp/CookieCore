using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6066)]
    public class LivingObjectMessageRequestMessage
    {
        [CustomVar]
        public ushort MsgId { get; set; }

        [LengthType(typeof(short), true)]
        public string[] Parameters { get; set; }

        [CustomVar]
        public uint LivingObject { get; set; }
    }
}