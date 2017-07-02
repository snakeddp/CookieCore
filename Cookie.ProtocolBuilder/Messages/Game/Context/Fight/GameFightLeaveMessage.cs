namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(721)]
    public class GameFightLeaveMessage
    {
        public double CharId { get; set; }
    }
}