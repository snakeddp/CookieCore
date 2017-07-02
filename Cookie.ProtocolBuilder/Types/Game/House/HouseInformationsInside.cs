namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(218)]
    public class HouseInformationsInside : HouseInformations
    {
        public HouseInstanceInformations HouseInfos { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
    }
}