
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(5932)]
    public class ContactLookRequestMessage
    {
        public sbyte RequestId { get; set; }
        public sbyte ContactType { get; set; }
    }
}
