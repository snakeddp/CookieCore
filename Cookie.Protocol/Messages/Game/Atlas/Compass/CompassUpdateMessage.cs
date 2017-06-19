
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Atlas.Compass
{
    [NetworkMessage(5591)]
    public class CompassUpdateMessage
    {
        public sbyte Type { get; set; }
        public MapCoordinates Coords { get; set; }
    }
}
