namespace Cookie.Protocol.Messages.Common.Basic
{
    [NetworkMessage(182)]
    public class BasicPingMessage
    {
        [RegularBool]
        public bool Quiet { get; set; }
    }
}