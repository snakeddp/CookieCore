using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(6384)]
    public class InteractiveUseErrorMessage
    {
        [CustomVar]
        public uint ElemId { get; set; }

        [CustomVar]
        public uint SkillInstanceUid { get; set; }
    }
}