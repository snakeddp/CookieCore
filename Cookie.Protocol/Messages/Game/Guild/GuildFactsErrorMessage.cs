
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6424)]
    public class GuildFactsErrorMessage
    {
        [CustomVar]
        public uint GuildId { get; set; }
    }
}
