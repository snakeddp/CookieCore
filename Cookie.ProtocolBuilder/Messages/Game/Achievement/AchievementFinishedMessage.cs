﻿namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6208)]
    public class AchievementFinishedMessage
    {
        [CustomVar]
        public ushort Id { get; set; }

        public sbyte Finishedlevel { get; set; }
    }
}