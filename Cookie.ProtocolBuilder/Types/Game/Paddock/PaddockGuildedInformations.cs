using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(508)]
    public class PaddockGuildedInformations : PaddockBuyableInformations
    {
        [RegularBool]
        public bool Deserted { get; set; }

        public GuildInformations GuildInfo { get; set; }
    }
}