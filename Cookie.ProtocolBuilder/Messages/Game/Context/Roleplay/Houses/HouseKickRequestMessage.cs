﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5698)]
    public class HouseKickRequestMessage
    {
        [CustomVar]
        public long Id { get; set; }
    }
}