
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Web.Haapi
{
    [NetworkMessage(6649)]
    public class HaapiApiKeyMessage
    {
        public sbyte ReturnType { get; set; }
        public sbyte KeyType { get; set; }
        public string Token { get; set; }
    }
}
