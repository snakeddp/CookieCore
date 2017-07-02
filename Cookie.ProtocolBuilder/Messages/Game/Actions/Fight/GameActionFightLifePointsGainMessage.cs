namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6311)]
    public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public uint Delta { get; set; }
    }
}