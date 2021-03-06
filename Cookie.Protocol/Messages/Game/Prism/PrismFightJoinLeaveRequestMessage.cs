﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5843)]
    public class PrismFightJoinLeaveRequestMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        [RegularBool]
        public bool Join { get; set; }
    }
}