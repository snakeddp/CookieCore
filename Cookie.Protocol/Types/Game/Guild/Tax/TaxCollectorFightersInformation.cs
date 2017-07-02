using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(169)]
    public class TaxCollectorFightersInformation
    {
        public int CollectorId { get; set; }
    }
}