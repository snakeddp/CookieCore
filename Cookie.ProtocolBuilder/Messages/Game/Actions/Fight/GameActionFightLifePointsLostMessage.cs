namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6312)]
    public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public uint Loss { get; set; }

        [CustomVar]
        public uint PermanentDamages { get; set; }
    }
}