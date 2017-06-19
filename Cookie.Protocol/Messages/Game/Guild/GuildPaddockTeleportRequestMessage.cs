
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5957)]
    public class GuildPaddockTeleportRequestMessage
    {
        public int PaddockId { get; set; }
    }
}
