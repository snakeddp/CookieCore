
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Alignment;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(203)]
    public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
    {
        public ActorAlignmentInformations AlignmentInfos { get; set; }
    }
}
