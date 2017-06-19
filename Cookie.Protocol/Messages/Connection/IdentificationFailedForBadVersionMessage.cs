
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Version;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(21)]
    public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
    {
        public Version RequiredVersion { get; set; }
    }
}
