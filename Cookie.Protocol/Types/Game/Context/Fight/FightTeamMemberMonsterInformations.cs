
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(6)]
    public class FightTeamMemberMonsterInformations : FightTeamMemberInformations
    {
        public int MonsterId { get; set; }
        public sbyte Grade { get; set; }
    }
}
