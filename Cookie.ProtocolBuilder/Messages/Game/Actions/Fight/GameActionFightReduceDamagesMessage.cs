namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5526)]
    public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public uint Amount { get; set; }
    }
}