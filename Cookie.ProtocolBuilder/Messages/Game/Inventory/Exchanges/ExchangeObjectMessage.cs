﻿namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5515)]
    public class ExchangeObjectMessage
    {
        [RegularBool]
        public bool Remote { get; set; }
    }
}