﻿namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5806)]
    public class ExchangeBidHouseSearchMessage
    {
        [CustomVar]
        public uint Type { get; set; }

        [CustomVar]
        public ushort GenId { get; set; }
    }
}