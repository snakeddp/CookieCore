﻿namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5817)]
    public class ExchangeStartOkMulticraftCustomerMessage
    {
        [CustomVar]
        public uint SkillId { get; set; }

        public sbyte CrafterJobLevel { get; set; }
    }
}