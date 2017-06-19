
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Job;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5649)]
    public class JobCrafterDirectoryDefineSettingsMessage
    {
        public JobCrafterDirectorySettings Settings { get; set; }
    }
}
