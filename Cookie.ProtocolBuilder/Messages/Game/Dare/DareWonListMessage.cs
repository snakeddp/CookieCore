namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6682)]
    public class DareWonListMessage
    {
        [LengthType(typeof(short), true)]
        public double[] DareId { get; set; }
    }
}