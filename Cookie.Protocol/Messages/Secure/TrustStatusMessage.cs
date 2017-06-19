
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Secure
{
    [NetworkMessage(6267)]
    public class TrustStatusMessage
    {
        public bool Trusted { get; set; }
        public bool Certified { get; set; }
    }
}
