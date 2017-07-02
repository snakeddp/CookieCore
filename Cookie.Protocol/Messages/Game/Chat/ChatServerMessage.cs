using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(881)]
    public class ChatServerMessage : ChatAbstractServerMessage
    {
        public double SenderId { get; set; }
        public string SenderName { get; set; }
        public uint SenderAccountId { get; set; }
    }
}