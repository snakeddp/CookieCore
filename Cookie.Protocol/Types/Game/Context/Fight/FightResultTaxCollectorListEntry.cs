
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(84)]
    public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
    {
        public sbyte Level { get; set; }
        public BasicGuildInformations GuildInfo { get; set; }
        public int ExperienceForGuild { get; set; }
    }
}
