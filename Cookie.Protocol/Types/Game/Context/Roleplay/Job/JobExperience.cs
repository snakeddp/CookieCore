
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(98)]
    public class JobExperience
    {
        public sbyte JobId { get; set; }
        public sbyte JobLevel { get; set; }
        [CustomVar]
        public long JobXP { get; set; }
        [CustomVar]
        public long JobXpLevelFloor { get; set; }
        [CustomVar]
        public long JobXpNextLevelFloor { get; set; }
    }
}
