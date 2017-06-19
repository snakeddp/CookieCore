
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(861)]
    public class ChatClientMultiMessage : ChatAbstractClientMessage
    {
        public sbyte Channel { get; set; }
    }
}
