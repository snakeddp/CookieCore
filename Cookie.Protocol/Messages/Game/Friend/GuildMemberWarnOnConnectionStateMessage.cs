﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6160)]
    public class GuildMemberWarnOnConnectionStateMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}