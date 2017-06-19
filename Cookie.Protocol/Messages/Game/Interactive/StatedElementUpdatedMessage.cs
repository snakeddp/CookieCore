
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Interactive;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(5709)]
    public class StatedElementUpdatedMessage
    {
        public StatedElement StatedElement { get; set; }
    }
}
