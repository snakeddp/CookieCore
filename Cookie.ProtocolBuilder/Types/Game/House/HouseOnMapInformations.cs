namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(510)]
    public class HouseOnMapInformations : HouseInformations
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] DoorsOnMap { get; set; }
    }
}