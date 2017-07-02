using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(431)]
    public class AllianceInsiderPrismInformation : PrismInformation
    {
        public uint LastTimeSlotModificationDate { get; set; }

        [CustomVar]
        public uint LastTimeSlotModificationAuthorGuildId { get; set; }

        [CustomVar]
        public long LastTimeSlotModificationAuthorId { get; set; }

        public string LastTimeSlotModificationAuthorName { get; set; }
    }
}