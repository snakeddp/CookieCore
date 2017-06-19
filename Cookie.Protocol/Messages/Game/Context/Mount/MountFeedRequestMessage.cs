
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6189)]
    public class MountFeedRequestMessage
    {
        [CustomVar]
        public uint MountUid { get; set; }
        public byte MountLocation { get; set; }
        [CustomVar]
        public uint MountFoodUid { get; set; }
        [CustomVar]
        public uint Quantity { get; set; }
    }
}
