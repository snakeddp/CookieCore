using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6034)]
    public class ObjectsDeletedMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectUID { get; set; }
    }
}