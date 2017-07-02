namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(200)]
    public class MapObstacle
    {
        [CustomVar]
        public ushort ObstacleCellId { get; set; }

        public sbyte State { get; set; }
    }
}