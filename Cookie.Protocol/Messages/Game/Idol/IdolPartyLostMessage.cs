﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6580)]
    public class IdolPartyLostMessage
    {
        [CustomVar]
        public ushort IdolId { get; set; }
    }
}