
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Creation
{
    [NetworkMessage(160)]
    public class CharacterCreationRequestMessage
    {
        public string Name { get; set; }
        public byte Breed { get; set; }
        [RegularBool]
        public bool Sex { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Colors { get; set; }
        [CustomVar]
        public ushort CosmeticId { get; set; }
    }
}
