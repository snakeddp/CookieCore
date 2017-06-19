
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(450)]
    public class GameFightCompanionInformations : GameFightFighterInformations
    {
        public sbyte CompanionGenericId { get; set; }
        public sbyte Level { get; set; }
        public double MasterId { get; set; }
    }
}
