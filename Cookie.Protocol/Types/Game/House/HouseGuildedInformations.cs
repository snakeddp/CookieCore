using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(512)]
    public class HouseGuildedInformations : HouseInstanceInformations
    {
        public GuildInformations GuildInfo { get; set; }
    }
}