
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Fight;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(117)]
    public class FightExternalInformations
    {
        public int FightId { get; set; }
        public sbyte FightType { get; set; }
        public uint FightStart { get; set; }
        [RegularBool]
        public bool FightSpectatorLocked { get; set; }
    }
}
