
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6393)]
    public class AllianceCreationValidMessage
    {
        public string AllianceName { get; set; }
        public string AllianceTag { get; set; }
        public GuildEmblem AllianceEmblem { get; set; }
    }
}
