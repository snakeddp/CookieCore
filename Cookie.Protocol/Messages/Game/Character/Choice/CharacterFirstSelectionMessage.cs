
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(6084)]
    public class CharacterFirstSelectionMessage : CharacterSelectionMessage
    {
        [RegularBool]
        public bool DoTutorial { get; set; }
    }
}
