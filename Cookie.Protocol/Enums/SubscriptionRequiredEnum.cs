using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SubscriptionRequiredEnum
    {
        LimitedToSubscriber = 0,
        LimitOnJobXp = 1,
        LimitOnJobUse = 2,
        LimitOnMap = 3,
        LimitOnItem = 4,
        LimitOnVendor = 5
    }
}
