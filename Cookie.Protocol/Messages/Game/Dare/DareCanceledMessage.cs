using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6679)]
    public class DareCanceledMessage
    {
        public double DareId { get; set; }
    }
}