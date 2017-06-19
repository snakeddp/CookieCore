
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6680)]
    public class DareCancelRequestMessage
    {
        public double DareId { get; set; }
    }
}
