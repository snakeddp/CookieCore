
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(454)]
    public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
    {
        public sbyte CompanionId { get; set; }
        public double MasterId { get; set; }
    }
}
