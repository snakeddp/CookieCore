﻿namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(132)]
    public class PaddockInformations
    {
        [CustomVar]
        public ushort MaxOutdoorMount { get; set; }

        [CustomVar]
        public ushort MaxItems { get; set; }
    }
}