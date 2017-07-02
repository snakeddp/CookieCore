using Cookie.Protocol.Types.Game.House;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5734)]
    public class HousePropertiesMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] DoorsOnMap { get; set; }

        public HouseInstanceInformations Properties { get; set; }
    }
}