
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(418)]
    public class BasicNamedAllianceInformations : BasicAllianceInformations
    {
        public string AllianceName { get; set; }
    }
}
