using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6323)]
    public class GuildModificationValidMessage
    {
        public string GuildName { get; set; }
        public GuildEmblem GuildEmblem { get; set; }
    }
}