
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6591)]
    public class GuildMotdSetErrorMessage : SocialNoticeSetErrorMessage
    {
    }
}
