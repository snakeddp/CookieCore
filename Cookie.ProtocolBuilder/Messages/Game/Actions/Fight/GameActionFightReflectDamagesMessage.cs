namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5530)]
    public class GameActionFightReflectDamagesMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}