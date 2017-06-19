
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6659)]
    public class DareInformationsRequestMessage
    {
        public double DareId { get; set; }
    }
}
