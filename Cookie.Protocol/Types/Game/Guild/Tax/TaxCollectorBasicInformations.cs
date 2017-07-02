using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(96)]
    public class TaxCollectorBasicInformations
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}