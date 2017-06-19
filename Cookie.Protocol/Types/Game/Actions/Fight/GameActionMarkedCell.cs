
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(85)]
    public class GameActionMarkedCell
    {
        [CustomVar]
        public ushort CellId { get; set; }
        public byte ZoneSize { get; set; }
        public int CellColor { get; set; }
        public byte CellsType { get; set; }
    }
}
