
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6078)]
    public class FriendWarnOnLevelGainStateMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}
