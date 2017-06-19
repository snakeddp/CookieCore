
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5653)]
    public class JobCrafterDirectoryRemoveMessage
    {
        public sbyte JobId { get; set; }
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
