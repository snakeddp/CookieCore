
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Interactive;

namespace Cookie.Protocol.Messages.Game.Interactive
{
    [NetworkMessage(5708)]
    public class InteractiveElementUpdatedMessage
    {
        public InteractiveElement InteractiveElement { get; set; }
    }
}
