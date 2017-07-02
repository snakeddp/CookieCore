namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5829)]
    public class GameActionFightThrowCharacterMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CellId { get; set; }
    }
}