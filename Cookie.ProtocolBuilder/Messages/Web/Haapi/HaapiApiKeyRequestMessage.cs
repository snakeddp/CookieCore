namespace Cookie.Protocol.Messages.Web.Haapi
{
    [NetworkMessage(6648)]
    public class HaapiApiKeyRequestMessage
    {
        public sbyte KeyType { get; set; }
    }
}