using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6522)]
    public class SymbioticObjectAssociateRequestMessage
    {
        [CustomVar]
        public uint SymbioteUID { get; set; }

        public sbyte SymbiotePos { get; set; }

        [CustomVar]
        public uint HostUID { get; set; }

        public sbyte HostPos { get; set; }
    }
}