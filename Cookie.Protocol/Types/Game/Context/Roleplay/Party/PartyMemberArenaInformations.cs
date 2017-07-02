using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(391)]
    public class PartyMemberArenaInformations : PartyMemberInformations
    {
        [CustomVar]
        public ushort Rank { get; set; }
    }
}