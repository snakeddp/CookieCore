using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Secure
{
    [NetworkType(377)]
    public class TrustCertificate
    {
        public uint Id { get; set; }
        public string Hash { get; set; }
    }
}