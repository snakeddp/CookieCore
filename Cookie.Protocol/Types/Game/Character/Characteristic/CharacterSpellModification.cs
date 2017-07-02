using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character.Characteristic
{
    [NetworkType(215)]
    public class CharacterSpellModification
    {
        public sbyte ModificationType { get; set; }

        [CustomVar]
        public ushort SpellId { get; set; }

        public CharacterBaseCharacteristic Value { get; set; }
    }
}