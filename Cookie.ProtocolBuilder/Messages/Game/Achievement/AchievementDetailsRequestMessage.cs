namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6380)]
    public class AchievementDetailsRequestMessage
    {
        [CustomVar]
        public ushort AchievementId { get; set; }
    }
}