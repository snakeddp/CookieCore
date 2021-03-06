﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3005)]
    public class ObjectDropMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}