﻿
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Prism;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(434)]
    public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
    {
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }
        public PrismInformation Prism { get; set; }
    }
}
