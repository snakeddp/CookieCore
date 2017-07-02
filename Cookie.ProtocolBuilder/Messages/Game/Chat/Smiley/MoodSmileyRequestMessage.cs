namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6192)]
    public class MoodSmileyRequestMessage
    {
        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}