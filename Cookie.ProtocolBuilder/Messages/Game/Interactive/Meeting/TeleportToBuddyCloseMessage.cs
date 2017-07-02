﻿namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6303)]
    public class TeleportToBuddyCloseMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }

        [CustomVar]
        public long BuddyId { get; set; }
    }
}