
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(195)]
    public class JobCrafterDirectoryEntryJobInfo
    {
        public sbyte JobId { get; set; }
        public sbyte JobLevel { get; set; }
        [RegularBool]
        public bool Free { get; set; }
        public sbyte MinLevel { get; set; }
    }
}
