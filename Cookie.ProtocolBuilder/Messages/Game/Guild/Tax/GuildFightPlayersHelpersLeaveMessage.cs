﻿namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5719)]
    public class GuildFightPlayersHelpersLeaveMessage
    {
        public uint FightId { get; set; }

        [CustomVar]
        public long PlayerId { get; set; }
    }
}