using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Connection.Search
{
    [NetworkMessage(6144)]
    public class AcquaintanceSearchMessage
    {
        public string Nickname { get; set; }
    }
}