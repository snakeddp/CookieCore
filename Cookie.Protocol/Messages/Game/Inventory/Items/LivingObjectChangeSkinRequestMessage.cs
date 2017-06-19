
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5725)]
    public class LivingObjectChangeSkinRequestMessage
    {
        [CustomVar]
        public uint LivingUID { get; set; }
        public sbyte LivingPosition { get; set; }
        [CustomVar]
        public uint SkinId { get; set; }
    }
}
