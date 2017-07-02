using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(167)]
    public class TaxCollectorInformations
    {
        public int UniqueId { get; set; }

        [CustomVar]
        public ushort FirtNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public AdditionalTaxCollectorInformations AdditionalInfos { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public sbyte State { get; set; }
        public EntityLook Look { get; set; }
    }
}