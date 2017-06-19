
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(3)]
    public class HelloConnectMessage
    {
        public string Salt { get; set; }
        [LengthType(typeof(int), true)]
        public byte[] Key { get; set; }
    }
}
