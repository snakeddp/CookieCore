
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(851)]
    public class ChatClientPrivateMessage : ChatAbstractClientMessage
    {
        public string Receiver { get; set; }
    }
}
