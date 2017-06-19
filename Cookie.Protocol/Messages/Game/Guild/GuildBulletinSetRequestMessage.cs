
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6694)]
    public class GuildBulletinSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }
        [RegularBool]
        public bool NotifyMembers { get; set; }
    }
}
