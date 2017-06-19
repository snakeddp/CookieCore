
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Debug
{
    [NetworkMessage(6028)]
    public class DebugInClientMessage
    {
        public sbyte Level { get; set; }
        public string Message { get; set; }
    }
}
