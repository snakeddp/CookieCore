
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(5622)]
    public class QuestStepInfoRequestMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
    }
}
