using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5826)]
    public class GameActionFightDropCharacterMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CellId { get; set; }
    }
}