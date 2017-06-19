
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6343)]
    public class KrosmasterInventoryErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}
