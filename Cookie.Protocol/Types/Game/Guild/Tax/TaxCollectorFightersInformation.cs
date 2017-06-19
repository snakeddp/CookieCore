
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(169)]
    public class TaxCollectorFightersInformation
    {
        public int CollectorId { get; set; }
    }
}
