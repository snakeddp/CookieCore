using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6450)]
    public class AllianceModificationValidMessage
    {
        public string AllianceName { get; set; }
        public string AllianceTag { get; set; }
        public GuildEmblem Alliancemblem { get; set; }
    }
}