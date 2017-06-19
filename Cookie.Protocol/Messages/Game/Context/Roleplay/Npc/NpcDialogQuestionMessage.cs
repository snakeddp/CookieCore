
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5617)]
    public class NpcDialogQuestionMessage
    {
        [CustomVar]
        public uint MessageId { get; set; }
        [LengthType(typeof(short), true)]
        public string[] DialogParams { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] VisibleReplies { get; set; }
    }
}
