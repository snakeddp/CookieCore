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