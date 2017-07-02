namespace Cookie.Protocol.Messages.Game.Actions.Sequence
{
    [NetworkMessage(955)]
    public class SequenceStartMessage
    {
        public byte SequenceType { get; set; }
        public double AuthorId { get; set; }
    }
}