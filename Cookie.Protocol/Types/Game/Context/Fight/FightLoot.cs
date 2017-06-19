
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(41)]
    public class FightLoot
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Objects { get; set; }
        [CustomVar]
        public long Kamas { get; set; }
    }
}
