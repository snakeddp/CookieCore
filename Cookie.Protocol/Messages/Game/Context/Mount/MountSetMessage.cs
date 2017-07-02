using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Mount;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5968)]
    public class MountSetMessage
    {
        public MountClientData MountData { get; set; }
    }
}