
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6383)]
    public class FriendGuildWarnOnAchievementCompleteStateMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}
