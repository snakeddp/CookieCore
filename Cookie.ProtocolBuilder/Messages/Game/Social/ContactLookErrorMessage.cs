namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(6045)]
    public class ContactLookErrorMessage
    {
        [CustomVar]
        public uint RequestId { get; set; }
    }
}