namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5679)]
    public class IgnoredAddFailureMessage
    {
        public sbyte Reason { get; set; }
    }
}