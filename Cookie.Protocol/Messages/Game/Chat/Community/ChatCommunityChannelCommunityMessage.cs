using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat.Community
{
    [NetworkMessage(6730)]
    public class ChatCommunityChannelCommunityMessage
    {
        public short CommunityId { get; set; }
    }
}