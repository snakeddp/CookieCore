
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Common
{
    [NetworkMessage(2)]
    public class NetworkDataContainerMessage
    {
        [LengthType(typeof(int), true)]
        public sbyte[] Content { get; set; }
    }
}
