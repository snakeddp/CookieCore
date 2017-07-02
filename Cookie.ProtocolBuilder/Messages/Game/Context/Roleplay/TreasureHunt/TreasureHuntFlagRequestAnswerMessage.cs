namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6507)]
    public class TreasureHuntFlagRequestAnswerMessage
    {
        public sbyte QuestType { get; set; }
        public sbyte Result { get; set; }
        public sbyte Index { get; set; }
    }
}