﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5755)]
    public class ExchangeBidPriceMessage
    {
        [CustomVar]
        public ushort GenericId { get; set; }

        [CustomVar]
        public long AveragePrice { get; set; }
    }
}