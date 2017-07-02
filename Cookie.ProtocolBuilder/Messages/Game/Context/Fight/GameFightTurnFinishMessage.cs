namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(718)]
    public class GameFightTurnFinishMessage
    {
        [RegularBool]
        public bool IsAfk { get; set; }
    }
}