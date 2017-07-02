using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(192)]
    public class FightResultExperienceData : FightResultAdditionalData
    {
        [CustomVar]
        public long Experience { get; set; }

        public bool ShowExperience { get; set; }

        [CustomVar]
        public long ExperienceLevelFloor { get; set; }

        public bool ShowExperienceLevelFloor { get; set; }

        [CustomVar]
        public long ExperienceNextLevelFloor { get; set; }

        public bool ShowExperienceNextLevelFloor { get; set; }

        [CustomVar]
        public long ExperienceFightDelta { get; set; }

        public bool ShowExperienceFightDelta { get; set; }

        [CustomVar]
        public long ExperienceForGuild { get; set; }

        public bool ShowExperienceForGuild { get; set; }

        [CustomVar]
        public long ExperienceForMount { get; set; }

        public bool ShowExperienceForMount { get; set; }
        public bool IsIncarnationExperience { get; set; }
        public sbyte RerollExperienceMul { get; set; }
    }
}