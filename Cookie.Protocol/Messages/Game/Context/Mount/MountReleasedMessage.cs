
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6308)]
    public class MountReleasedMessage
    {
        [CustomVar]
        public int MountId { get; set; }
    }
}
