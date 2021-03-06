﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6138)]
    public class PaddockToSellListMessage
    {
        [CustomVar]
        public ushort PageIndex { get; set; }

        [CustomVar]
        public ushort TotalPage { get; set; }
    }
}