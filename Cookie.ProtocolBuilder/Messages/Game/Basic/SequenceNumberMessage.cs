namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6317)]
    public class SequenceNumberMessage
    {
        public ushort Number { get; set; }
    }
}