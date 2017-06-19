
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(440)]
    public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
    {
        public AllianceInformations AllianceIdentity { get; set; }
    }
}
