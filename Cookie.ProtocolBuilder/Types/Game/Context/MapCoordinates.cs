namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(174)]
    public class MapCoordinates
    {
        public short WorldX { get; set; }
        public short WorldY { get; set; }
    }
}