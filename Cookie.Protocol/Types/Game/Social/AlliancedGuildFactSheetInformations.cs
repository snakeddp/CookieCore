
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(422)]
    public class AlliancedGuildFactSheetInformations : GuildInformations
    {
        public BasicNamedAllianceInformations AllianceInfos { get; set; }
    }
}
