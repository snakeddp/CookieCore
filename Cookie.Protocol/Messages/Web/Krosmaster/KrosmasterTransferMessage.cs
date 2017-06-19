
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6348)]
    public class KrosmasterTransferMessage
    {
        public string Uid { get; set; }
        public sbyte Failure { get; set; }
    }
}
