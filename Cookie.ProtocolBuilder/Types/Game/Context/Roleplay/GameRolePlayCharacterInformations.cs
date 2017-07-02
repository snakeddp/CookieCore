using Cookie.Protocol.Types.Game.Character.Alignment;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(36)]
    public class GameRolePlayCharacterInformations : GameRolePlayHumanoidInformations
    {
        public ActorAlignmentInformations AlignmentInfos { get; set; }
    }
}