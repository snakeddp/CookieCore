
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(148)]
    public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
    {
        public TaxCollectorStaticInformations Identification { get; set; }
        public sbyte GuildLevel { get; set; }
        public int TaxCollectorAttack { get; set; }
    }
}
