
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(214)]
    public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
    {
        public short StateId { get; set; }
    }
}
