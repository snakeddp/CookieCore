namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6239)]
    public class GameFightNewRoundMessage
    {
        [CustomVar]
        public uint RoundNumber { get; set; }
    }
}