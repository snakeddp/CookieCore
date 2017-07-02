using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Web.Ankabox
{
    [NetworkMessage(6292)]
    public class NewMailMessage : MailStatusMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] SendersAccountId { get; set; }
    }
}