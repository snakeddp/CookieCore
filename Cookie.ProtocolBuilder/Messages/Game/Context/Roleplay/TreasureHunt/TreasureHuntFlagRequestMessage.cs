namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6508)]
    public class TreasureHuntFlagRequestMessage
    {
        public sbyte QuestType { get; set; }
        public sbyte Index { get; set; }
    }
}