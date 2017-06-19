
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Subscriber
{
    [NetworkMessage(5542)]
    public class SubscriptionLimitationMessage
    {
        public sbyte Reason { get; set; }
    }
}
