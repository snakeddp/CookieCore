
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(5934)]
    public class ContactLookMessage
    {
        [CustomVar]
        public uint RequestId { get; set; }
        public string PlayerName { get; set; }
        [CustomVar]
        public long PlayerId { get; set; }
        public EntityLook Look { get; set; }
    }
}
