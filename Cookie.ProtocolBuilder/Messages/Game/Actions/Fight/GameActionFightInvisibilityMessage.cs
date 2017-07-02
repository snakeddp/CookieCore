namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5821)]
    public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public sbyte State { get; set; }
    }
}