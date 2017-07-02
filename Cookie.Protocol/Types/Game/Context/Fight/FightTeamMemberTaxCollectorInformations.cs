using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(177)]
    public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public sbyte Level { get; set; }

        [CustomVar]
        public uint GuildId { get; set; }

        [CustomVar]
        public uint Uid { get; set; }
    }
}