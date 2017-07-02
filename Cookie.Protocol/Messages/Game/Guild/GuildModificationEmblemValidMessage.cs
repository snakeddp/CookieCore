using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6328)]
    public class GuildModificationEmblemValidMessage
    {
        public GuildEmblem GuildEmblem { get; set; }
    }
}