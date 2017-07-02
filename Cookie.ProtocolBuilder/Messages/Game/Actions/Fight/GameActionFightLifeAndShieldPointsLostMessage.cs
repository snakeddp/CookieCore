namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6310)]
    public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
    {
        [CustomVar]
        public ushort ShieldLoss { get; set; }
    }
}