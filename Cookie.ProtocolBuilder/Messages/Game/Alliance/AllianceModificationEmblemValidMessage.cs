using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6447)]
    public class AllianceModificationEmblemValidMessage
    {
        public GuildEmblem Alliancemblem { get; set; }
    }
}