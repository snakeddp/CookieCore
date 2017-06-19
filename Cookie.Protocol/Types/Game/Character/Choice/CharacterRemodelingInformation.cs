
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(479)]
    public class CharacterRemodelingInformation : AbstractCharacterInformation
    {
        public string Name { get; set; }
        public byte Breed { get; set; }
        [RegularBool]
        public bool Sex { get; set; }
        [CustomVar]
        public ushort CosmeticId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Colors { get; set; }
    }
}
