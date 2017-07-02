using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(1010)]
    public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }

        public short SpellLevel { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public short[] PortalsIds { get; set; }
    }
}