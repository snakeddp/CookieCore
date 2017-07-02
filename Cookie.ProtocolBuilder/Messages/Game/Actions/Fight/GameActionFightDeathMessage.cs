namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(1099)]
    public class GameActionFightDeathMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}