namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(196)]
    public class JobCrafterDirectoryListEntry
    {
        public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
        public JobCrafterDirectoryEntryJobInfo JobInfo { get; set; }
    }
}