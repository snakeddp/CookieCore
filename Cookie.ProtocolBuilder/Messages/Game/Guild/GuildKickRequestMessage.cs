﻿namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5887)]
    public class GuildKickRequestMessage
    {
        [CustomVar]
        public long KickedId { get; set; }
    }
}