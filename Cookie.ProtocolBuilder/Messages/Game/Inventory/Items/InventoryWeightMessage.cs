﻿namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3009)]
    public class InventoryWeightMessage
    {
        [CustomVar]
        public uint Weight { get; set; }

        [CustomVar]
        public uint WeightMax { get; set; }
    }
}