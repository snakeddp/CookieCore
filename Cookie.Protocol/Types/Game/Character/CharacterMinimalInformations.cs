
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(110)]
    public class CharacterMinimalInformations : CharacterBasicMinimalInformations
    {
        public sbyte Level { get; set; }
    }
}
