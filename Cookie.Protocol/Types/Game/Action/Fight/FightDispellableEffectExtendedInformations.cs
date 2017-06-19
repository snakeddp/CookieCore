
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Actions.Fight;

namespace Cookie.Protocol.Types.Game.Action.Fight
{
    [NetworkType(208)]
    public class FightDispellableEffectExtendedInformations
    {
        [CustomVar]
        public ushort ActionId { get; set; }
        public double SourceId { get; set; }
        public AbstractFightDispellableEffect Effect { get; set; }
    }
}
