using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6527)]
    public class SymbioticObjectAssociatedMessage
    {
        [CustomVar]
        public uint HostUID { get; set; }
    }
}