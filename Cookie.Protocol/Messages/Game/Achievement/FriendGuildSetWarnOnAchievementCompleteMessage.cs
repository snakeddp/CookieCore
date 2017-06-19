
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6382)]
    public class FriendGuildSetWarnOnAchievementCompleteMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}
