
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6699)]
    public class RefreshCharacterStatsMessage
    {
        public double FighterId { get; set; }
        public GameFightMinimalStats Stats { get; set; }
    }
}
