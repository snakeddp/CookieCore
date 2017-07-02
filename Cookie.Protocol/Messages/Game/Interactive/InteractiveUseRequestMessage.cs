using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(5001)]
    public class InteractiveUseRequestMessage
    {
        [CustomVar]
        public uint ElemId { get; set; }

        [CustomVar]
        public uint SkillInstanceUid { get; set; }
    }
}