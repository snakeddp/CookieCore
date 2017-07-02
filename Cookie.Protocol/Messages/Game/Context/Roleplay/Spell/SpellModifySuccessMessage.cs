using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Spell
{
    [NetworkMessage(6654)]
    public class SpellModifySuccessMessage
    {
        public int SpellId { get; set; }
        public short SpellLevel { get; set; }
    }
}