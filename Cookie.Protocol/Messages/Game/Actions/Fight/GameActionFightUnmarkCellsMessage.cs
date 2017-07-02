using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5570)]
    public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
    {
        public short MarkId { get; set; }
    }
}