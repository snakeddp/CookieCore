using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Mount;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5973)]
    public class MountDataMessage
    {
        public MountClientData MountData { get; set; }
    }
}