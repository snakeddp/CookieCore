using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(147)]
    public class TaxCollectorStaticInformations
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public GuildInformations GuildIdentity { get; set; }
    }
}