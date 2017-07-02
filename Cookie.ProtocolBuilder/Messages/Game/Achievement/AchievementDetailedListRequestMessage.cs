namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6357)]
    public class AchievementDetailedListRequestMessage
    {
        [CustomVar]
        public ushort CategoryId { get; set; }
    }
}