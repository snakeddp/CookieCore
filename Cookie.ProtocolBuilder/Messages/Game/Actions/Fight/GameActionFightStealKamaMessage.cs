namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5535)]
    public class GameActionFightStealKamaMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public long Amount { get; set; }
    }
}