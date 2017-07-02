namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6491)]
    public class TreasureHuntAvailableRetryCountUpdateMessage
    {
        public sbyte QuestType { get; set; }
        public int AvailableRetryCount { get; set; }
    }
}