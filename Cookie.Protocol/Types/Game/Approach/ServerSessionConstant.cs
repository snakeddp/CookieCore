﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Approach
{
    [NetworkType(430)]
    public class ServerSessionConstant
    {
        [CustomVar]
        public ushort Id { get; set; }
    }
}