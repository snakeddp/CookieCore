
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(883)]
    public class ChatServerWithObjectMessage : ChatServerMessage
    {
    }
}
