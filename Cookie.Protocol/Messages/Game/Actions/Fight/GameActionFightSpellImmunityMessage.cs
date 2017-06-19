
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6221)]
    public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        [CustomVar]
        public ushort SpellId { get; set; }
    }
}
