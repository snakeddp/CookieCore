
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Interactive.Skill;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(101)]
    public class JobDescription
    {
        public sbyte JobId { get; set; }
    }
}
