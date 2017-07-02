using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(427)]
    public class AlliancePrismInformation : PrismInformation
    {
        public AllianceInformations Alliance { get; set; }
    }
}