﻿namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6159)]
    public class GuildMemberSetWarnOnConnectionMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}