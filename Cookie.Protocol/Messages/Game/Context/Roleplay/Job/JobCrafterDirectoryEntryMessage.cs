
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Job;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(6044)]
    public class JobCrafterDirectoryEntryMessage
    {
        public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
        public EntityLook PlayerLook { get; set; }
    }
}
