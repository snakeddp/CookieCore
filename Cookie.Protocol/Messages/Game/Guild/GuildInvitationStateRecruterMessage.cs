using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5563)]
    public class GuildInvitationStateRecruterMessage
    {
        public string RecrutedName { get; set; }
        public sbyte InvitationState { get; set; }
    }
}