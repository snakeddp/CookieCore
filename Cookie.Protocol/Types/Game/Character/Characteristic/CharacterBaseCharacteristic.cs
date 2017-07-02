using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character.Characteristic
{
    [NetworkType(4)]
    public class CharacterBaseCharacteristic
    {
        [CustomVar]
        public short Base { get; set; }

        [CustomVar]
        public short Additionnal { get; set; }

        [CustomVar]
        public short ObjectsAndMountBonus { get; set; }

        [CustomVar]
        public short AlignGiftBonus { get; set; }

        [CustomVar]
        public short ContextModif { get; set; }
    }
}