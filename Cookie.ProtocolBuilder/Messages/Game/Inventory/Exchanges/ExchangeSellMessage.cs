﻿namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5778)]
    public class ExchangeSellMessage
    {
        [CustomVar]
        public uint ObjectToSellId { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}