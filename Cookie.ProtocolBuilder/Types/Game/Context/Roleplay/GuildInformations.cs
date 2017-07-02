using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(127)]
    public class GuildInformations : BasicGuildInformations
    {
        public GuildEmblem GuildEmblem { get; set; }
    }
}