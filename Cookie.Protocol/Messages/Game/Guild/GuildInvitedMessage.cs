using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5552)]
    public class GuildInvitedMessage
    {
        [CustomVar]
        public long RecruterId { get; set; }

        public string RecruterName { get; set; }
        public BasicGuildInformations GuildInfo { get; set; }
    }
}