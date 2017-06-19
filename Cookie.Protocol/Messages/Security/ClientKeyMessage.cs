
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Security
{
    [NetworkMessage(5607)]
    public class ClientKeyMessage
    {
        public string Key { get; set; }
    }
}
