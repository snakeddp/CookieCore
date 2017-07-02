namespace Cookie.Protocol.Messages.Game.Character.Creation
{
    [NetworkMessage(5544)]
    public class CharacterNameSuggestionSuccessMessage
    {
        public string Suggestion { get; set; }
    }
}