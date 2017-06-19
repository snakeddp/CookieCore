﻿
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(175)]
    public class AtlasPointsInformations
    {
        public sbyte Type { get; set; }
    }
}