namespace Cookie.Protocol.Messages.Game.Chat.Community
{
    [NetworkMessage(6729)]
    public class ChatCommunityChannelSetCommunityRequestMessage
    {
        public short CommunityId { get; set; }
    }
}