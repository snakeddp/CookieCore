using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Creation
{
    [NetworkMessage(164)]
    public class CharacterNameSuggestionFailureMessage
    {
        public sbyte Reason { get; set; }
    }
}