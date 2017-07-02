using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(5745)]
    public class InteractiveUsedMessage
    {
        [CustomVar]
        public long EntityId { get; set; }

        [CustomVar]
        public uint ElemId { get; set; }

        [CustomVar]
        public ushort SkillId { get; set; }

        [CustomVar]
        public ushort Duration { get; set; }

        [RegularBool]
        public bool CanMove { get; set; }
    }
}