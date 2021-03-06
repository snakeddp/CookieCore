﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(181)]
    public class BasicWhoIsRequestMessage
    {
        [RegularBool]
        public bool Verbose { get; set; }

        public string Search { get; set; }
    }
}