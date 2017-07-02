using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(152)]
    public class CharacterSelectionMessage
    {
        [CustomVar]
        public long Id { get; set; }
    }
}