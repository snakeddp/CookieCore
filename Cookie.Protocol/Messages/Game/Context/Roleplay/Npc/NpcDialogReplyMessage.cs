using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5616)]
    public class NpcDialogReplyMessage
    {
        [CustomVar]
        public uint ReplyId { get; set; }
    }
}