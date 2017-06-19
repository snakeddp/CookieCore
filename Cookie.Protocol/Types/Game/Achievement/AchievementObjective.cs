﻿
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Achievement
{
    [NetworkType(404)]
    public class AchievementObjective
    {
        [CustomVar]
        public uint Id { get; set; }
        [CustomVar]
        public ushort MaxValue { get; set; }
    }
}
