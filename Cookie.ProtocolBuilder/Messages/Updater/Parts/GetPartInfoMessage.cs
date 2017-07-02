namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1506)]
    public class GetPartInfoMessage
    {
        public string Id { get; set; }
    }
}