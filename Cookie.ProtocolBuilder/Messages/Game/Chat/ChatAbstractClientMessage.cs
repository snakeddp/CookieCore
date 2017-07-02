namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(850)]
    public class ChatAbstractClientMessage
    {
        public string Content { get; set; }
    }
}