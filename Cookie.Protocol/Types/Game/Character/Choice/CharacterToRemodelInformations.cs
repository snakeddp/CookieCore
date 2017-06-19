
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(477)]
    public class CharacterToRemodelInformations : CharacterRemodelingInformation
    {
        public sbyte PossibleChangeMask { get; set; }
        public sbyte MandatoryChangeMask { get; set; }
    }
}
