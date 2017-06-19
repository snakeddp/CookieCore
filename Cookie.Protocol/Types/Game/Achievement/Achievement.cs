
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Achievement;
using Cookie.Protocol.Types.Game.Achievement;

namespace Cookie.Protocol.Types.Game.Achievement
{
    [NetworkType(363)]
    public class Achievement
    {
        [CustomVar]
        public ushort Id { get; set; }
    }
}
