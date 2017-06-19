
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Fight;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(447)]
    public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
    {
        public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
    }
}
