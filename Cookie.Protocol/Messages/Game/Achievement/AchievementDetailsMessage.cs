using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6378)]
    public class AchievementDetailsMessage
    {
        public Types.Game.Achievement.Achievement Achievement { get; set; }
    }
}