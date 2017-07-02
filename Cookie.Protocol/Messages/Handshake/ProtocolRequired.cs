using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Handshake
{
    [NetworkMessage(1)]
    public class ProtocolRequired
    {
        public uint RequiredVersion { get; set; }
        public uint CurrentVersion { get; set; }
    }
}