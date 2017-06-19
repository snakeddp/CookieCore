
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6687)]
    public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }
    }
}
