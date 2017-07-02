using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6489)]
    public class TreasureHuntRequestAnswerMessage
    {
        public sbyte QuestType { get; set; }
        public sbyte Result { get; set; }
    }
}