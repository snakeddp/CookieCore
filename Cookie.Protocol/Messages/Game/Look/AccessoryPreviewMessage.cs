
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Messages.Game.Look
{
    [NetworkMessage(6517)]
    public class AccessoryPreviewMessage
    {
        public EntityLook Look { get; set; }
    }
}
