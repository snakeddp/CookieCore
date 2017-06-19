
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5546)]
    public class GuildCreationValidMessage
    {
        public string GuildName { get; set; }
        public GuildEmblem GuildEmblem { get; set; }
    }
}
