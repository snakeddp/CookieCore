using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6297)]
    public class NumericWhoIsMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }

        public uint AccountId { get; set; }
    }
}