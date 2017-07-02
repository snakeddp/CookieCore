﻿namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(500)]
    public class JobBookSubscription
    {
        public sbyte JobId { get; set; }

        [RegularBool]
        public bool Subscribed { get; set; }
    }
}