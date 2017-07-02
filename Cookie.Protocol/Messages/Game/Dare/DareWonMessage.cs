using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6681)]
    public class DareWonMessage
    {
        public double DareId { get; set; }
    }
}