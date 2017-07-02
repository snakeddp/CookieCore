using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(432)]
    public class AllianceVersatileInformations
    {
        [CustomVar]
        public uint AllianceId { get; set; }

        [CustomVar]
        public ushort NbGuilds { get; set; }

        [CustomVar]
        public ushort NbMembers { get; set; }

        [CustomVar]
        public ushort NbSubarea { get; set; }
    }
}