
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6176)]
    public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }
    }
}
