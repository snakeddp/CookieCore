using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(392)]
    public class MapCoordinatesAndId : MapCoordinates
    {
        public int MapId { get; set; }
    }
}