﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(6140)]
    public class HouseToSellListMessage
    {
        [CustomVar]
        public ushort PageIndex { get; set; }

        [CustomVar]
        public ushort TotalPage { get; set; }
    }
}