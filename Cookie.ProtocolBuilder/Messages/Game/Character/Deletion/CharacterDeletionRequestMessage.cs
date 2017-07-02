namespace Cookie.Protocol.Messages.Game.Character.Deletion
{
    [NetworkMessage(165)]
    public class CharacterDeletionRequestMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }

        public string SecretAnswerHash { get; set; }
    }
}