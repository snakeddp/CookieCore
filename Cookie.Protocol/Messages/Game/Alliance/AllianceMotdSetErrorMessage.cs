
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Social;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6683)]
    public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
    {
    }
}
