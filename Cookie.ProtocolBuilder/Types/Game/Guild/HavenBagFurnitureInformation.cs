namespace Cookie.Protocol.Types.Game.Guild
{
    [NetworkType(498)]
    public class HavenBagFurnitureInformation
    {
        [CustomVar]
        public ushort CellId { get; set; }

        public int FunitureId { get; set; }
        public sbyte Orientation { get; set; }
    }
}