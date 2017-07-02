namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(714)]
    public class GameFightTurnStartMessage
    {
        public double Id { get; set; }

        [CustomVar]
        public uint WaitTime { get; set; }
    }
}