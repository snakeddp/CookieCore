using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6320)]
    public class GameActionFightInvisibleDetectedMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CellId { get; set; }
    }
}