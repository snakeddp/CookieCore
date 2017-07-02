using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6396)]
    public class AllianceInvitationStateRecruterMessage
    {
        public string RecrutedName { get; set; }
        public sbyte InvitationState { get; set; }
    }
}