﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6183)]
    public class ExchangeObjectTransfertListFromInvMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Ids { get; set; }
    }
}