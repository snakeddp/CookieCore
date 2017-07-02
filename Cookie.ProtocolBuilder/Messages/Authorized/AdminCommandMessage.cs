namespace Cookie.Protocol.Messages.Authorized
{
    [NetworkMessage(76)]
    public class AdminCommandMessage
    {
        public string Content { get; set; }
    }
}