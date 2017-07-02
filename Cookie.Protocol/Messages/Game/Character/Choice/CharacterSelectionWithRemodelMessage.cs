using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Choice;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(6549)]
    public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
    {
        public RemodelingInformation Remodel { get; set; }
    }
}