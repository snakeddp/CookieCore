using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5564)]
    public class GuildJoinedMessage
    {
        public GuildInformations GuildInfo { get; set; }

        [CustomVar]
        public uint MemberRights { get; set; }
    }
}