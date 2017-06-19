
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3010)]
    public class ObjectMovementMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
        public sbyte Position { get; set; }
    }
}
