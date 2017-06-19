
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(40)]
    public class ServerSelectionMessage
    {
        [CustomVar]
        public ushort ServerId { get; set; }
    }
}
