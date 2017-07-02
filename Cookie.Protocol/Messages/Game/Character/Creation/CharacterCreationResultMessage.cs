using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Creation
{
    [NetworkMessage(161)]
    public class CharacterCreationResultMessage
    {
        public sbyte Result { get; set; }
    }
}