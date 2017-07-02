using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3019)]
    public class ObjectUseMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}