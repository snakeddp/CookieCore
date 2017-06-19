
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(6209)]
    public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
    {
        public string LoginToken { get; set; }
    }
}
