
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(870)]
    public class ChatErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}
