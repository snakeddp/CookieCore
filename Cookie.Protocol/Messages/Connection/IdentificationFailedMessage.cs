using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(20)]
    public class IdentificationFailedMessage
    {
        public sbyte Reason { get; set; }
    }
}