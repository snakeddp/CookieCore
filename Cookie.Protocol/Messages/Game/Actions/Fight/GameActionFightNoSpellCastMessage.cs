
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6132)]
    public class GameActionFightNoSpellCastMessage
    {
        [CustomVar]
        public uint SpellLevelId { get; set; }
    }
}
