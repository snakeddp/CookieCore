namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6588)]
    public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }
    }
}