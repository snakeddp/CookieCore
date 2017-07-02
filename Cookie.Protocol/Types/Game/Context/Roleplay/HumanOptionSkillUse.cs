using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(495)]
    public class HumanOptionSkillUse : HumanOption
    {
        [CustomVar]
        public uint ElementId { get; set; }

        [CustomVar]
        public ushort SkillId { get; set; }

        public double SkillEndTime { get; set; }
    }
}