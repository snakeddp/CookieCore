using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(366)]
    public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
    {
        public int ImmuneSpellId { get; set; }
    }
}