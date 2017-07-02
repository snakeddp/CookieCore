using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6091)]
    public class QuestStartedMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
    }
}