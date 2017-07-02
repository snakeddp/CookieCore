using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(97)]
    public class JobCrafterDirectorySettings
    {
        public sbyte JobId { get; set; }
        public sbyte MinLevel { get; set; }

        [RegularBool]
        public bool Free { get; set; }
    }
}