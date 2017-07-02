namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(713)]
    public class GameFightTurnListMessage
    {
        [LengthType(typeof(short), true)]
        public double[] Ids { get; set; }

        [LengthType(typeof(short), true)]
        public double[] DeadsIds { get; set; }
    }
}