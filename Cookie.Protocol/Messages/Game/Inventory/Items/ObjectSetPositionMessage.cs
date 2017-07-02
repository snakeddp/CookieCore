using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3021)]
    public class ObjectSetPositionMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        public sbyte Position { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}