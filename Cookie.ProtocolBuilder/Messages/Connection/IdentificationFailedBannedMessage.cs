namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(6174)]
    public class IdentificationFailedBannedMessage : IdentificationFailedMessage
    {
        public double BanEndDate { get; set; }
    }
}