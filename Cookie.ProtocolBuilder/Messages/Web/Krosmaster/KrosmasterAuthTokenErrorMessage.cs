namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6345)]
    public class KrosmasterAuthTokenErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}