namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6349)]
    public class KrosmasterTransferRequestMessage
    {
        public string Uid { get; set; }
    }
}