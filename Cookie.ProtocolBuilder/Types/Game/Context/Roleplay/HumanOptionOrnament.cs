﻿namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(411)]
    public class HumanOptionOrnament : HumanOption
    {
        [CustomVar]
        public ushort OrnamentId { get; set; }
    }
}