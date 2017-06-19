
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5844)]
    public class PrismInfoJoinLeaveRequestMessage
    {
        [RegularBool]
        public bool Join { get; set; }
    }
}
