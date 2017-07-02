using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5987)]
    public class MountRenameRequestMessage
    {
        public string Name { get; set; }

        [CustomVar]
        public int MountId { get; set; }
    }
}