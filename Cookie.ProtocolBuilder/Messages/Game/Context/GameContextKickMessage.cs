namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(6081)]
    public class GameContextKickMessage
    {
        public double TargetId { get; set; }
    }
}