namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(435)]
    public class GuildVersatileInformations
    {
        [CustomVar]
        public uint GuildId { get; set; }

        [CustomVar]
        public long LeaderId { get; set; }

        public sbyte GuildLevel { get; set; }
        public sbyte NbMembers { get; set; }
    }
}