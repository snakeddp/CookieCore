
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5830)]
    public class GameActionFightCarryCharacterMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CellId { get; set; }
    }
}
