
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Achievement
{
    [NetworkType(402)]
    public class AchievementStartedObjective : AchievementObjective
    {
        [CustomVar]
        public ushort Value { get; set; }
    }
}
