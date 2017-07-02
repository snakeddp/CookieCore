using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6376)]
    public class AchievementRewardSuccessMessage
    {
        public short AchievementId { get; set; }
    }
}