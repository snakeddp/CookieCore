namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(365)]
    public class BasicGuildInformations : AbstractSocialGroupInfos
    {
        [CustomVar]
        public uint GuildId { get; set; }

        public string GuildName { get; set; }
        public sbyte GuildLevel { get; set; }
    }
}