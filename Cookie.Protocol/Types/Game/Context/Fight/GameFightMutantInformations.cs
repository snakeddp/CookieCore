
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(50)]
    public class GameFightMutantInformations : GameFightFighterNamedInformations
    {
        public sbyte PowerLevel { get; set; }
    }
}
