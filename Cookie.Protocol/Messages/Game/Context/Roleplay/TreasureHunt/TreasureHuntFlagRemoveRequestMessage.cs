
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6510)]
    public class TreasureHuntFlagRemoveRequestMessage
    {
        public sbyte QuestType { get; set; }
        public sbyte Index { get; set; }
    }
}
