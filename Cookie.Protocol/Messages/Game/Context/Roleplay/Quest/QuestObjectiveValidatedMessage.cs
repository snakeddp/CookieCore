
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6098)]
    public class QuestObjectiveValidatedMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
        [CustomVar]
        public ushort ObjectiveId { get; set; }
    }
}
