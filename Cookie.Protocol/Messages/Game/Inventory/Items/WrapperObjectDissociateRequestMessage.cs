﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6524)]
    public class WrapperObjectDissociateRequestMessage
    {
        [CustomVar]
        public uint HostUID { get; set; }

        public sbyte HostPos { get; set; }
    }
}