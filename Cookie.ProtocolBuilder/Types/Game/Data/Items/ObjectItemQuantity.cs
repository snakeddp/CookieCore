﻿namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(119)]
    public class ObjectItemQuantity : Item
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}