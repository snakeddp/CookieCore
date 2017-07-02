using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(446)]
    public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
    {
        public BasicGuildInformations Guild { get; set; }
    }
}