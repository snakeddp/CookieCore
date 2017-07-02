using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6588)]
    public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }
    }
}