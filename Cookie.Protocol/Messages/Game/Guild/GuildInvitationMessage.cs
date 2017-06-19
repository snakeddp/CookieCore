
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5551)]
    public class GuildInvitationMessage
    {
        [CustomVar]
        public long TargetId { get; set; }
    }
}
