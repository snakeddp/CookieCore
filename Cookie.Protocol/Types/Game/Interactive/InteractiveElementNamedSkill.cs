using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(220)]
    public class InteractiveElementNamedSkill : InteractiveElementSkill
    {
        [CustomVar]
        public uint NameId { get; set; }
    }
}