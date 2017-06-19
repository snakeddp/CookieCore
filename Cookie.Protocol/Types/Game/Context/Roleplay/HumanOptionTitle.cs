
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(408)]
    public class HumanOptionTitle : HumanOption
    {
        [CustomVar]
        public ushort TitleId { get; set; }
        public string TitleParam { get; set; }
    }
}
