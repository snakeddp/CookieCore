﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5574)]
    public class PartyStopFollowRequestMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}