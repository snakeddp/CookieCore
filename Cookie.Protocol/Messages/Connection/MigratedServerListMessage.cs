
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(6731)]
    public class MigratedServerListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] MigratedServerIds { get; set; }
    }
}
