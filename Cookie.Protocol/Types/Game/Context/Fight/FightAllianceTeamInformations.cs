
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(439)]
    public class FightAllianceTeamInformations : FightTeamInformations
    {
        public sbyte Relation { get; set; }
    }
}
