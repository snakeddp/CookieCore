namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(6120)]
    public class CharactersListWithModificationsMessage : CharactersListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] CharactersToRename { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] UnusableCharacters { get; set; }
    }
}