namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(252)]
    public class GameContextRemoveMultipleElementsMessage
    {
        [LengthType(typeof(short), true)]
        public double[] ElementsIds { get; set; }
    }
}