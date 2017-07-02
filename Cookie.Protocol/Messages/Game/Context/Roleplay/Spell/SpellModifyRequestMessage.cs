using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Spell
{
    [NetworkMessage(6655)]
    public class SpellModifyRequestMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }

        public short SpellLevel { get; set; }
    }
}