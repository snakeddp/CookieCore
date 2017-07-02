namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(437)]
    public class GuildInAllianceVersatileInformations : GuildVersatileInformations
    {
        [CustomVar]
        public uint AllianceId { get; set; }
    }
}