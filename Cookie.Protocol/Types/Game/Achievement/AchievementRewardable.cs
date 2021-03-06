﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Achievement
{
    [NetworkType(412)]
    public class AchievementRewardable
    {
        [CustomVar]
        public ushort Id { get; set; }

        public sbyte Finishedlevel { get; set; }
    }
}