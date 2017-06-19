
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6298)]
    public class NumericWhoIsRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
