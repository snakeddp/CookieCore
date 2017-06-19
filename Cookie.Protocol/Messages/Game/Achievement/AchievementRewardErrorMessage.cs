
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6375)]
    public class AchievementRewardErrorMessage
    {
        public short AchievementId { get; set; }
    }
}
