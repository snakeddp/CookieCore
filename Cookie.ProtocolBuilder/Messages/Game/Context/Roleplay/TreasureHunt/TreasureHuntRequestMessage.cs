namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6488)]
    public class TreasureHuntRequestMessage
    {
        public sbyte QuestLevel { get; set; }
        public sbyte QuestType { get; set; }
    }
}