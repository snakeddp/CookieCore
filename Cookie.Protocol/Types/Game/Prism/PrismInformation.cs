using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(428)]
    public class PrismInformation
    {
        public sbyte TypeId { get; set; }
        public sbyte State { get; set; }
        public uint NextVulnerabilityDate { get; set; }
        public uint PlacementDate { get; set; }

        [CustomVar]
        public uint RewardTokenCount { get; set; }
    }
}