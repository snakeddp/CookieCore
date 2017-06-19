
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(6688)]
    public class SocialNoticeMessage
    {
        public string Content { get; set; }
        public uint Timestamp { get; set; }
        [CustomVar]
        public long MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
