using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5923)]
    public class GuildMemberLeavingMessage
    {
        [RegularBool]
        public bool Kicked { get; set; }

        [CustomVar]
        public long MemberId { get; set; }
    }
}