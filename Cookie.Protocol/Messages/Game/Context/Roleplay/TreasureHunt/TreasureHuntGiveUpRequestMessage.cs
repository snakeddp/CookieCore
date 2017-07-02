using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6487)]
    public class TreasureHuntGiveUpRequestMessage
    {
        public sbyte QuestType { get; set; }
    }
}