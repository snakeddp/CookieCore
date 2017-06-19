
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6096)]
    public class QuestStepStartedMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
        [CustomVar]
        public ushort StepId { get; set; }
    }
}
