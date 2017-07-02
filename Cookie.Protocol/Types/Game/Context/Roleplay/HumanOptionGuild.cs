using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(409)]
    public class HumanOptionGuild : HumanOption
    {
        public GuildInformations GuildInformations { get; set; }
    }
}