
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Achievement;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6378)]
    public class AchievementDetailsMessage
    {
        public Types.Game.Achievement.Achievement Achievement { get; set; }
    }
}
