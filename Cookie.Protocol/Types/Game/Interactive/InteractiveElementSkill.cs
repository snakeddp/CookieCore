﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(219)]
    public class InteractiveElementSkill
    {
        [CustomVar]
        public uint SkillId { get; set; }

        public uint SkillInstanceUid { get; set; }
    }
}