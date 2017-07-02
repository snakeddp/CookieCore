namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(152)]
    public class CharacterSelectionMessage
    {
        [CustomVar]
        public long Id { get; set; }
    }
}