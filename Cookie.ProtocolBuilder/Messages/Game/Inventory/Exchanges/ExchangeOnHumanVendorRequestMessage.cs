﻿namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5772)]
    public class ExchangeOnHumanVendorRequestMessage
    {
        [CustomVar]
        public long HumanVendorId { get; set; }

        [CustomVar]
        public ushort HumanVendorCell { get; set; }
    }
}