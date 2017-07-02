using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6685)]
    public class AllianceMotdMessage : SocialNoticeMessage
    {
    }
}