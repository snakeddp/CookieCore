using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(5612)]
    public class ShowCellMessage
    {
        public double SourceId { get; set; }

        [CustomVar]
        public ushort CellId { get; set; }
    }
}