﻿namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(5658)]
    public class UpdateLifePointsMessage
    {
        [CustomVar]
        public uint LifePoints { get; set; }

        [CustomVar]
        public uint MaxLifePoints { get; set; }
    }
}