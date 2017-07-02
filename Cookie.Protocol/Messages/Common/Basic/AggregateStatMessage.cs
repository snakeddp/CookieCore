using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Common.Basic
{
    [NetworkMessage(6669)]
    public class AggregateStatMessage
    {
        [CustomVar]
        public ushort StatId { get; set; }
    }
}