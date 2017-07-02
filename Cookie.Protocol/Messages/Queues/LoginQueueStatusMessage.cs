using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Queues
{
    [NetworkMessage(10)]
    public class LoginQueueStatusMessage
    {
        public ushort Position { get; set; }
        public ushort Total { get; set; }
    }
}