
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5527)]
    public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CasterCellId { get; set; }
        public short TargetCellId { get; set; }
    }
}
