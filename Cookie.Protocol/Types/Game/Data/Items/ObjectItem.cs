
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items.Effects;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(37)]
    public class ObjectItem : Item
    {
        public sbyte Position { get; set; }
        [CustomVar]
        public ushort ObjectGID { get; set; }
        [CustomVar]
        public uint ObjectUID { get; set; }
        [CustomVar]
        public uint Quantity { get; set; }
    }
}
