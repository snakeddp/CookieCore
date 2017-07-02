using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(426)]
    public class FightTeamMemberWithAllianceCharacterInformations : FightTeamMemberCharacterInformations
    {
        public BasicAllianceInformations AllianceInfos { get; set; }
    }
}