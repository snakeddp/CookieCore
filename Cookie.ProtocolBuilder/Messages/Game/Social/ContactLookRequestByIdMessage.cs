namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(5935)]
    public class ContactLookRequestByIdMessage : ContactLookRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}