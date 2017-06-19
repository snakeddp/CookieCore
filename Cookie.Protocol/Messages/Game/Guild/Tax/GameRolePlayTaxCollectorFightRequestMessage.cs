
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5954)]
    public class GameRolePlayTaxCollectorFightRequestMessage
    {
        public int TaxCollectorId { get; set; }
    }
}
