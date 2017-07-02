namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(176)]
    public class MapCoordinatesExtended : MapCoordinatesAndId
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}