
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Job;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5651)]
    public class JobCrafterDirectoryAddMessage
    {
        public JobCrafterDirectoryListEntry ListEntry { get; set; }
    }
}
