using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(6216)]
    public class AccountCapabilitiesMessage
    {
        public uint AccountId { get; set; }
        public bool TutorialAvailable { get; set; }

        [CustomVar]
        public uint BreedsVisible { get; set; }

        [CustomVar]
        public uint BreedsAvailable { get; set; }

        public byte Status { get; set; }
        public bool CanCreateNewCharacter { get; set; }
    }
}