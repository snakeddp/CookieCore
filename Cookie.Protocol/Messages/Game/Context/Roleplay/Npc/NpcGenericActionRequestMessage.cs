
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5898)]
    public class NpcGenericActionRequestMessage
    {
        public int NpcId { get; set; }
        public sbyte NpcActionId { get; set; }
        public int NpcMapId { get; set; }
    }
}
