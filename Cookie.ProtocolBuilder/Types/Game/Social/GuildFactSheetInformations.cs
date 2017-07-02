namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(424)]
    public class GuildFactSheetInformations : GuildInformations
    {
        [CustomVar]
        public long LeaderId { get; set; }

        [CustomVar]
        public ushort NbMembers { get; set; }
    }
}