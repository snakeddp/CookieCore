﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6426)]
    public class AllianceChangeGuildRightsMessage
    {
        [CustomVar]
        public uint GuildId { get; set; }

        public sbyte Rights { get; set; }
    }
}