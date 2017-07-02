using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5548)]
    public class GuildInvitationStateRecrutedMessage
    {
        public sbyte InvitationState { get; set; }
    }
}