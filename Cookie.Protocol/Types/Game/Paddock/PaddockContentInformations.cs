﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(183)]
    public class PaddockContentInformations : PaddockInformations
    {
        public int PaddockId { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        [RegularBool]
        public bool Abandonned { get; set; }
    }
}