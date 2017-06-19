
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6723)]
    public class UnfollowQuestObjectiveRequestMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
        public short ObjectiveId { get; set; }
    }
}
