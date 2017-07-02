namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(800)]
    public class ChatSmileyRequestMessage
    {
        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}