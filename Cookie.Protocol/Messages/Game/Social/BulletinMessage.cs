using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(6695)]
    public class BulletinMessage : SocialNoticeMessage
    {
        public uint LastNotifiedTimestamp { get; set; }
    }
}