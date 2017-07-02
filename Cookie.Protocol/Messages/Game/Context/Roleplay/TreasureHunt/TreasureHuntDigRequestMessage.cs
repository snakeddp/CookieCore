using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6485)]
    public class TreasureHuntDigRequestMessage
    {
        public sbyte QuestType { get; set; }
    }
}