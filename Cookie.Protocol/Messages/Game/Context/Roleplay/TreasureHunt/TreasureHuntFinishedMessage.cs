using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6483)]
    public class TreasureHuntFinishedMessage
    {
        public sbyte QuestType { get; set; }
    }
}