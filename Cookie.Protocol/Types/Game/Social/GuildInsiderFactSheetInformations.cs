
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(423)]
    public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
    {
        public string LeaderName { get; set; }
        [CustomVar]
        public ushort NbConnectedMembers { get; set; }
        public sbyte NbTaxCollectors { get; set; }
        public uint LastActivity { get; set; }
    }
}
