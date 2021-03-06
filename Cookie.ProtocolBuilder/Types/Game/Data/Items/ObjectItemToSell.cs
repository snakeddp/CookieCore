﻿namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(120)]
    public class ObjectItemToSell : Item
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }

        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }

        [CustomVar]
        public long ObjectPrice { get; set; }
    }
}