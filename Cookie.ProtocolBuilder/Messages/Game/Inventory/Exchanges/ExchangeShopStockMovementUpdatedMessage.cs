﻿using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5909)]
    public class ExchangeShopStockMovementUpdatedMessage
    {
        public ObjectItemToSell ObjectInfo { get; set; }
    }
}