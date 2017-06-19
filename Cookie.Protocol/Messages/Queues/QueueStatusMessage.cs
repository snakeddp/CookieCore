
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Queues
{
    [NetworkMessage(6100)]
    public class QueueStatusMessage
    {
        public ushort Position { get; set; }
        public ushort Total { get; set; }
    }
}
