﻿using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5516)]
    public class ExchangeObjectAddedMessage : ExchangeObjectMessage
    {
        public ObjectItem Object { get; set; }
    }
}