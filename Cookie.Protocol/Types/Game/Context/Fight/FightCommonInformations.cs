using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(43)]
    public class FightCommonInformations
    {
        public int FightId { get; set; }
        public sbyte FightType { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] FightTeamsPositions { get; set; }
    }
}