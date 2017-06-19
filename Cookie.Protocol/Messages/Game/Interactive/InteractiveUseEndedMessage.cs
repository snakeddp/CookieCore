
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(6112)]
    public class InteractiveUseEndedMessage
    {
        [CustomVar]
        public uint ElemId { get; set; }
        [CustomVar]
        public ushort SkillId { get; set; }
    }
}
