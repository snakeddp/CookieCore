
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(13)]
    public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
    {
        public string Name { get; set; }
        public sbyte Level { get; set; }
    }
}
