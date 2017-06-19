
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(5611)]
    public class ShowCellRequestMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}
