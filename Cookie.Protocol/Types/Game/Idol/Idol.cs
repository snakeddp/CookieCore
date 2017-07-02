using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Idol
{
    [NetworkType(489)]
    public class Idol
    {
        [CustomVar]
        public ushort Id { get; set; }

        [CustomVar]
        public ushort XpBonusPercent { get; set; }

        [CustomVar]
        public ushort DropBonusPercent { get; set; }
    }
}