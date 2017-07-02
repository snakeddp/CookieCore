namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5525)]
    public class GameActionFightSlideMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short StartCellId { get; set; }
        public short EndCellId { get; set; }
    }
}