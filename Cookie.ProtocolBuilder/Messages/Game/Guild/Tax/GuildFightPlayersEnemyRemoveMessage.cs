﻿namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5929)]
    public class GuildFightPlayersEnemyRemoveMessage
    {
        public uint FightId { get; set; }

        [CustomVar]
        public long PlayerId { get; set; }
    }
}