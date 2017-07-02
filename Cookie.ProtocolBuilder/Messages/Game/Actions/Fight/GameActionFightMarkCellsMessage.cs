using Cookie.Protocol.Types.Game.Actions.Fight;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5540)]
    public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
    {
        public GameActionMark Mark { get; set; }
    }
}