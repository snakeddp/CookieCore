
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Alignment;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(46)]
    public class GameFightCharacterInformations : GameFightFighterNamedInformations
    {
        public sbyte Level { get; set; }
        public ActorAlignmentInformations AlignmentInfos { get; set; }
        public byte Breed { get; set; }
        [RegularBool]
        public bool Sex { get; set; }
    }
}
