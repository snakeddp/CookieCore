using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(417)]
    public class AllianceInformations : BasicNamedAllianceInformations
    {
        public GuildEmblem AllianceEmblem { get; set; }
    }
}