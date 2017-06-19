
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5556)]
    public class GuildInvitationAnswerMessage
    {
        [RegularBool]
        public bool Accept { get; set; }
    }
}
