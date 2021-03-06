﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Subscriber
{
    [NetworkMessage(5573)]
    public class SubscriptionZoneMessage
    {
        [RegularBool]
        public bool Active { get; set; }
    }
}