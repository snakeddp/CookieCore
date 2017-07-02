using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6351)]
    public class KrosmasterAuthTokenMessage
    {
        public string Token { get; set; }
    }
}