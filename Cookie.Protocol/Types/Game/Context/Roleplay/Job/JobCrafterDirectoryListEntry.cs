
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Job;
using Cookie.Protocol.Types.Game.Context.Roleplay.Job;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(196)]
    public class JobCrafterDirectoryListEntry
    {
        public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
        public JobCrafterDirectoryEntryJobInfo JobInfo { get; set; }
    }
}
