
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6395)]
    public class AllianceInvitationMessage
    {
        [CustomVar]
        public long TargetId { get; set; }
    }
}
