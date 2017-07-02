namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(1030)]
    public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short Delta { get; set; }
    }
}