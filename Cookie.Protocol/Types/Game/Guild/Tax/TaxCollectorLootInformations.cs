
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(372)]
    public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
    {
        [CustomVar]
        public long Kamas { get; set; }
        [CustomVar]
        public long Experience { get; set; }
        [CustomVar]
        public uint Pods { get; set; }
        [CustomVar]
        public long ItemsValue { get; set; }
    }
}
