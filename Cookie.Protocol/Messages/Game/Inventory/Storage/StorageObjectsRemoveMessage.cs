using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(6035)]
    public class StorageObjectsRemoveMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectUIDList { get; set; }
    }
}