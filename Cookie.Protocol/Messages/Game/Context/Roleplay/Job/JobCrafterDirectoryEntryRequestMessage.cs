using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(6043)]
    public class JobCrafterDirectoryEntryRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}