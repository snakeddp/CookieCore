
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Security
{
    [NetworkMessage(6372)]
    public class CheckIntegrityMessage
    {
        [LengthType(typeof(int), true)]
        public byte[] Data { get; set; }
    }
}
