using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5642)]
    public class MapNpcsQuestStatusUpdateMessage
    {
        public int MapId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] NpcsIdsWithQuest { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] NpcsIdsWithoutQuest { get; set; }
    }
}