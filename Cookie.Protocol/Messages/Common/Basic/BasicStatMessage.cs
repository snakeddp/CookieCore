using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Common.Basic
{
    [NetworkMessage(6530)]
    public class BasicStatMessage
    {
        public double TimeSpent { get; set; }

        [CustomVar]
        public ushort StatId { get; set; }
    }
}