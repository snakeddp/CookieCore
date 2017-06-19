
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(6047)]
    public class JobCrafterDirectoryListRequestMessage
    {
        public sbyte JobId { get; set; }
    }
}
