using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(6119)]
    public class IdentificationAccountForceMessage : IdentificationMessage
    {
        public string ForcedAccountLogin { get; set; }
    }
}