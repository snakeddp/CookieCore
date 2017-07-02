namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6377)]
    public class AchievementRewardRequestMessage
    {
        public short AchievementId { get; set; }
    }
}