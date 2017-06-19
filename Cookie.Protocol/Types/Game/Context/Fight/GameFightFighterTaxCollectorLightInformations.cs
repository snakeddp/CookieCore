
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(457)]
    public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }
        [CustomVar]
        public ushort LastNameId { get; set; }
    }
}
