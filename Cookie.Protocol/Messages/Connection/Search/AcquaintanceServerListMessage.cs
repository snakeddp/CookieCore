using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection.Search
{
    [NetworkMessage(6142)]
    public class AcquaintanceServerListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Servers { get; set; }
    }
}