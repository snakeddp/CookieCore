using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5597)]
    public class GuildInformationsMemberUpdateMessage
    {
        public GuildMember Member { get; set; }
    }
}