
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Version;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(4)]
    public class IdentificationMessage
    {
        public VersionExtended Version { get; set; }
        public string Lang { get; set; }
        [LengthType(typeof(int), true)]
        public byte[] Credentials { get; set; }
        public short ServerId { get; set; }
        public bool Autoconnect { get; set; }
        public bool UseCertificate { get; set; }
        public bool UseLoginToken { get; set; }
        [CustomVar]
        public long SessionOptionalSalt { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] FailedAttempts { get; set; }
    }
}
