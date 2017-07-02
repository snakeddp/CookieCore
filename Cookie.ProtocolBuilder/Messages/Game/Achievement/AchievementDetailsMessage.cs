namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6378)]
    public class AchievementDetailsMessage
    {
        public Achievement Achievement { get; set; }
    }
}