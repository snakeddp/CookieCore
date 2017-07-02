namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(390)]
    public class AccountHouseInformations : HouseInformations
    {
        public HouseInstanceInformations HouseInfos { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}