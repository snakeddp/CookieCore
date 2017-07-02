﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6468)]
    public class PrismSetSabotagedRequestMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}