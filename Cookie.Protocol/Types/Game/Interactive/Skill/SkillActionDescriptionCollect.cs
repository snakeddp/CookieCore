using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Interactive.Skill
{
    [NetworkType(99)]
    public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
    {
        [CustomVar]
        public ushort Min { get; set; }

        [CustomVar]
        public ushort Max { get; set; }
    }
}