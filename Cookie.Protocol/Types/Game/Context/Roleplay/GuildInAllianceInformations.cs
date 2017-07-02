using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(420)]
    public class GuildInAllianceInformations : GuildInformations
    {
        public sbyte NbMembers { get; set; }
    }
}