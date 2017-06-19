
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6484)]
    public class TreasureHuntDigRequestAnswerMessage
    {
        public sbyte QuestType { get; set; }
        public sbyte Result { get; set; }
    }
}
