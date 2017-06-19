
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6040)]
    public class PrismFightStateUpdateMessage
    {
        public sbyte State { get; set; }
    }
}
