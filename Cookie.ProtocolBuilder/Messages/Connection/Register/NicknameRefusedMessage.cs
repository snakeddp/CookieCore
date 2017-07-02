namespace Cookie.Protocol.Messages.Connection.Register
{
    [NetworkMessage(5638)]
    public class NicknameRefusedMessage
    {
        public sbyte Reason { get; set; }
    }
}