namespace Cookie.Protocol.Messages.Subscription
{
    [NetworkMessage(6616)]
    public class SubscriptionUpdateMessage
    {
        public double Timestamp { get; set; }
    }
}